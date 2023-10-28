using CommandDesignPattern;

Light livingRoomLight = new Light();
LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

RemoteControl remoteControl = new RemoteControl();
remoteControl.SetCommand(livingRoomLightOn);
remoteControl.SetCommand(livingRoomLightOff);

remoteControl.ExecuteCommands();
