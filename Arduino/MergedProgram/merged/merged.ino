#include <ArduinoJson.h>
// Motor 1 Pins
const int m1_FwPin = 49; // Set forward mode on M1
const int m1_BwPin = 48; // Set backward mode om M1
const int m1_SpeedPin = 4; // set motor speed on M1
const int m1_FaultPin = 43; // Read FaultMessage on M1. Is activated by the wheelchairs dead man's switch.
const int m1_wheelSensPin = 2; // Read pulse sensor on wheel 1.

// Motor 2 Pins
const int m2_FwPin = 47;
const int m2_BwPin = 46;
const int m2_SpeedPin = 5;
const int m2_FaultPin = 42;
const int m2_wheelSensPin = 3;

// Other Pins
const int voltagePin = A0; // Read battery voltage
const int frontCollisionPin = 33;
const int lidar_Q1Pin = 34;
const int lidar_Q2Pin = 35;
const int lidar_Q3Pin = 36;
const int lidar_Q4Pin = 37;
const int reflection1Pin = 38;
const int reflection2Pin = 39;

// Non example variables
String incomingString="";
int velocity = 0;
bool drive, left, right,leftRef,rightRef,q1stat, q2stat, q3stat, q4stat,_auto;
const int cap=JSON_OBJECT_SIZE(17);



StaticJsonDocument<200> inDoc;
StaticJsonDocument<cap> outDoc;


void setup() {
  // put your setup code here, to run once:

  // Motor 1 setup:
  pinMode(m1_FwPin, OUTPUT);
  pinMode(m1_BwPin, OUTPUT);
  pinMode(m1_SpeedPin, OUTPUT);
  pinMode(m1_FaultPin, INPUT);
  pinMode(m1_wheelSensPin, INPUT);
  attachInterrupt(digitalPinToInterrupt(m1_wheelSensPin), Wheel1Movement, RISING);

  // Motor 2 setup:
  pinMode(m2_FwPin, OUTPUT);
  pinMode(m2_BwPin, OUTPUT);
  pinMode(m2_SpeedPin, OUTPUT);
  pinMode(m2_FaultPin, INPUT);
  pinMode(m2_wheelSensPin, INPUT);
  attachInterrupt(digitalPinToInterrupt(m2_wheelSensPin), Wheel2Movement, RISING);

  // Setup for other pins:
  pinMode(voltagePin, INPUT);
  pinMode(frontCollisionPin, INPUT);
  pinMode(lidar_Q1Pin, INPUT);
  pinMode(lidar_Q2Pin, INPUT);
  pinMode(lidar_Q3Pin, INPUT);
  pinMode(lidar_Q4Pin, INPUT);
  pinMode(reflection1Pin, INPUT);
  pinMode(reflection2Pin, INPUT);

  Serial.begin(115200);

}
void loop() {
  // put your main code here, to run repeatedly:
 checkLidar();
  if (Serial.available() > 0) {
    // read the incoming string
    incomingString = Serial.readStringUntil('\n');
    decodeMsg();
  }
  decideDriveMode();
  codeMsg();
  //delay(100);
}
void decideDriveMode(){
  if(_auto){
    selfDriving();
    
  }
  else{
    manualDriving();
    
  }
}
void readFloorSensors(){
  leftRef = digitalRead(reflection1Pin);
  rightRef = digitalRead(reflection2Pin);
}
void selfDriving(){
  readFloorSensors();
  if((leftRef)&&(rightRef)){
    stopIt();
  }
  else if(leftRef){
    turnRight();
  }
  else if(rightRef){
    turnLeft();
  }
  else{
   goForward(); 
  }
}
void turnLeft(){
  while(rightRef){
    if(rightRef&&leftRef){
      stopIt();
      break;
    }
    else{
      SetM1Speed(int(velocity*0.1));
      SetM2Speed(velocity);
    }
   readFloorSensors(); 
  }
}
void turnRight(){
  while(leftRef){
    if(rightRef&&leftRef){
      stopIt();
      break;
    }
    else{
     SetM1Speed(velocity);
     SetM2Speed(int(velocity*0.1)); 
    }
   readFloorSensors(); 
  }
}
void goForward(){
  SetM1Speed(velocity);
  SetM2Speed(velocity);
}
void stopIt(){
  velocity =0;
  drive = false;
  SetM1Speed(0);
  SetM2Speed(0);
}
void checkLidar(){
  q1stat= digitalRead(lidar_Q1Pin);
  q2stat= digitalRead(lidar_Q2Pin);
  q3stat= digitalRead(lidar_Q3Pin);
  q4stat= digitalRead(lidar_Q4Pin);
  if(q1stat){
    stopIt();
  }
}
void decodeMsg(){
  DeserializationError err=deserializeJson(inDoc, incomingString);
  velocity = inDoc["Speed"];
  drive = inDoc["Drive"];
  left = inDoc["Left"];
  right = inDoc["Right"];
  _auto = inDoc["Auto"];  
}
void codeMsg(){
      /*public bool EmergencyStop { get; set; }

        public int Speed { get; set; }

        public bool Zone1Tripped { get; set; }

        public bool Zone2Tripped { get; set; }

        public bool Zone3Tripped { get; set; }

        public bool Zone4Tripped { get; set; }

        public int BatteryLevel { get; set; }*/
    
    outDoc["EmergencyStop"]=false;//Not yet implemented
    outDoc["Speed"]=velocity;
    outDoc["Zone1Tripped"]=q1stat;
    outDoc["Zone2Tripped"]=q2stat;
    outDoc["Zone3Tripped"]=q3stat;
    outDoc["Zone4Tripped"]=q4stat;
    outDoc["BatteryLevel"]=analogRead(voltagePin);
    serializeJson(outDoc,Serial);
    Serial.println();//adds a line break
}
void manualDriving(){
if((drive == true) && (!q1stat)){
    if(left){
    SetM1Speed(-velocity);
    SetM2Speed(velocity);
    }
   else if(right){
    SetM1Speed(velocity);
    SetM2Speed(-velocity);
   }
   else{
    goForward();
   }
  }
  else{
    //stå stille
    stopIt();
  }
  
}
 void Wheel1Movement() {
  // Method runs when the wheel_1 sensor detects a rising edge.
  //Serial.println("wh1");
}

void Wheel2Movement() {
  // Method runs when the wheel_2 sensor detects a rising edge.
  //Serial.println("wh2");
}
void SetM1Speed(int sp) {
  // This method is used to set the speed of wheel1.
  // This is the only method that is allowed to write to the motor1 pins.
  int sp_send = min(100,abs(sp)); // Safety speed limit
  digitalWrite(m1_FwPin, sp > 0);
  digitalWrite(m1_BwPin, sp < 0);
  analogWrite(m1_SpeedPin, sp_send);
}

void SetM2Speed(int sp) {
  // This method is used to set the speed of wheel2.
  // This is the only method that is allowed to write to the motor2 pins.
  int sp_send = min(100,abs(sp)); // Safety speed limit
  digitalWrite(m2_FwPin, sp > 0);
  digitalWrite(m2_BwPin, sp < 0);
  analogWrite(m2_SpeedPin, sp_send);
}
