const int led4=13;
const int led3=12;
const int led2=11;
const int led1=10;
const int ch1 = 6;
const int ch2 = 7;
const int ch3 = 8;
const int ch4 = 9;
const int tom = 5;

void setup()
{
  pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
  pinMode(led3, OUTPUT);
  pinMode(led4, OUTPUT);
  pinMode(tom, OUTPUT);
  pinMode(ch1, INPUT);
  pinMode(ch2, INPUT);
  pinMode(ch3, INPUT);
  pinMode(ch4, INPUT);
}

void loop()
{
  if(digitalRead(ch1) == HIGH)
  {
    tone(tom, 1000,1000);
    digitalWrite(led1, HIGH);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led4, LOW);
  }
  if(digitalRead(ch2) == HIGH)
  {
    tone(tom, 1500,1000);
    digitalWrite(led1, LOW);
    digitalWrite(led2, HIGH);
    digitalWrite(led3, LOW);
    digitalWrite(led4, LOW);    
  }
  if(digitalRead(ch3) == HIGH)
  {
    tone(tom, 2000,1000);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, HIGH);
    digitalWrite(led4, LOW);    
  } 
  if(digitalRead(ch4) == HIGH)
  {
    tone(tom, 2500,1000);
    digitalWrite(led1, LOW);
    digitalWrite(led2, LOW);
    digitalWrite(led3, LOW);
    digitalWrite(led4, HIGH);    
  }   
}


