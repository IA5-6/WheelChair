#include <ArduinoJson.h>

String incomingByte="";
void setup() {
  // put your setup code here, to run once:
  Serial.setTimeout(5000);
Serial.begin(115200);
}
StaticJsonDocument<200> doc;


void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available() > 0) {
    ///Serial.println("Jeg fikk noe på øret her");
    delay(2000);
    // read the incoming byte:
    incomingByte = Serial.readStringUntil('\n');
    //Serial.print("Jeg fikk: ");
    
    //Serial.println(incomingByte);
    doc["isForward"] = true;
    doc["Speed"] = 25;
    
    doc["Drive"] = "false";
    serializeJson(doc,Serial);
    Serial.println();
}
  delay(1000);
}
