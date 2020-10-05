#include <ArduinoJson.h>

String incomingByte="";
int speed = 0;
bool drive, left, right;

void setup() {
  // put your setup code here, to run once:
  Serial.setTimeout(5000);
Serial.begin(115200);
}
StaticJsonDocument<200> inDoc;
StaticJsonDocument<200> outDoc;

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available() > 0) {
    ///Serial.println("Jeg fikk noe på øret her");
    delay(2000);
    // read the incoming byte:
    incomingByte = Serial.readStringUntil('\n');
    decodeMsg();
    
  }
  codeMsg();
  delay(1000);
}

void decodeMsg(){
  DeserializationError err=deserializeJson(inDoc, incomingByte);
  speed = inDoc["Speed"];
  drive = inDoc["Drive"];
  left = inDoc["Left"];
  right = inDoc["Right"];
  if(drive == true && !(left||right)){
    //Go forward
  }
  else if(left){
    //Go left
  }
  else if(right){
    //Go right
  }
  else{
    //stå stille
  }
}
void codeMsg(){
      /*public bool EmergencyStop { get; set; }

        public int Speed { get; set; }

        public bool Zone1Tripped { get; set; }

        public bool Zone2Tripped { get; set; }

        public bool Zone3Tripped { get; set; }

        public bool Zone4Tripped { get; set; }

        public int BatteryLevel { get; set; }*/
    
    outDoc["EmergencyStop"]="false";
    outDoc["Speed"]=speed;
    outDoc["Zone1Tripped"]="false";
    outDoc["Zone2Tripped"]="true";
    outDoc["Zone3Tripped"]="false";
    outDoc["Zone4Tripped"]="true";
    outDoc["BatteryLevel"]=50;
    serializeJson(outDoc,Serial);
    Serial.println();//adds a line break
}
