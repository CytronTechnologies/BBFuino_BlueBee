const char led1 = 12;  //assign led1 is with digital pin 12 of BBFuino
const char led2 = 13;  //assign led2 is assigned with digital pin 13 of BBFuino
char buffer = 0;  //declare a variable to store the character received from hyperterminal, initialize it with 
void setup()
{
 Serial.begin(9600); //initialize serial communication with baudrate = 9600bps (UART is used for this case)
 Serial.flush();  //flush out the contents in the receive buffer
 pinMode(led1,OUTPUT); //set the led1 (or digital pin 12) as output
 pinMode(led2,OUTPUT); //set the led2 (or digital pin 13) as output
}

void loop()
{ 
  while(!Serial.available()) //wait for any character received at RX buffer
  {
    if (buffer == '1')  //Turn on LED1 and LED2 if buffer = character '1'
    {
      digitalWrite(led1,HIGH);
      digitalWrite(led2,HIGH);
    }
    
    else if (buffer == '2')  //Turn off LED1 and LED2 if buffer = character '2'
    {
      digitalWrite(led1,LOW);
      digitalWrite(led2,LOW);
    }
    
    else if (buffer == '3') //Makes LED1 and LED2 blink if buffer = character '3'
    {
      digitalWrite(led1,HIGH);
      digitalWrite(led2,HIGH);
      delay(200);
      digitalWrite(led1,LOW);
      digitalWrite(led2,LOW);
      delay(200);
    }
  }
  buffer = Serial.read(); //store the received character in variable buffer
  if (buffer == '1')  //print string "LED1 and LED2 are on" to hyperterminal if buffer contains character '1'
    Serial.println("LED1 and LED2 are on");
  else if(buffer == '2')  //print string "LED1 and LED2 are off" to hyperterminal if buffer contains character '2'
    Serial.println("LED1 and LED2 are off");
  else if(buffer == '3')  //print string "LED1 and LED2 are blinking" to hyperterminal if buffer contains character '3'
    Serial.println("LED1 and LED2 are blinking");
  else //print string "Nothing change" to hyperterminal if buffer contains character neither '1', '2' or '3'
    Serial.println("Nothing change");
}
