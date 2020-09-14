String incomingByte="";
void setup() {
  // put your setup code here, to run once:
  Serial.setTimeout(5000);
Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
if (Serial.available() > 0) {
    ///erial.println("Jeg fikk noe på øret her");
    delay(2000);
    // read the incoming byte:
    incomingByte = Serial.readStringUntil('\n');
    
  
  //Serial.print("Jeg fikk: ");
  Serial.println(incomingByte);
}
  delay(1000);
}
