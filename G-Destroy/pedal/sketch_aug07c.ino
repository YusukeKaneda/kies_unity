// serial_voltage_byte_sample1

const int led_pin = 9;
const int vol_pin = 1;

int vol_value = 0;

void setup() {
  Serial.begin( 9600 );
}

void loop() {
  vol_value = analogRead( vol_pin );

 // analogWrite( led_pin, vol_value/4 );

 // Serial.write( byte(vol_value/4) );
  vol_value -= 1023;
  vol_value = -vol_value;

  
  Serial.println(vol_value);
  
  delay( 50 );
}
