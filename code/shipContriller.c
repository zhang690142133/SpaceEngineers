public Program()
{
    Runtime.UpdateFrequency = UpdateFrequency.Update1;
}

public void Save()
{

}
public void Main(string argument, UpdateType updateSource)
{
    //获取当前玩家所在驾驶舱
    List<IMyShipController> cockpits=new List<IMyShipController>();
    GridTerminalSystem.GetBlocksOfType<IMyShipController>(cockpits,Controller=>Controller.IsUnderControl);
    if(cockpits.Count<1)return;
    IMyShipController cockpit=cockpits[0];
     Vector3D targetThrustPower=new Vector3D(cockpit.MoveIndicator.X*100f,cockpit.MoveIndicator.Y*100f,cockpit.MoveIndicator.Z*100f);
    //自动减速(简单)
    //转换为相对速度（坐标系转换）
    MatrixD refLookAtMatrix =MatrixD.CreateLookAt(Vector3D.Zero,cockpit.WorldMatrix.Forward,cockpit.WorldMatrix.Up);
    if(cockpit.DampenersOverride&&targetThrustPower==Vector3D.Zero)targetThrustPower=-Vector3D.TransformNormal(cockpit.GetShipVelocities().LinearVelocity,refLookAtMatrix);
    cockpit.IsMainCockpit=false;
    IMyMotorAdvancedStator LCD = GridTerminalSystem.GetBlockWithName("LCD_1") as IMyMotorAdvancedStator; 
    LCD.TargetVelocityRPM=1;
    log("引擎控制接管中...\n"+targetThrustPower.ToString()+'\n'+cockpit.RotationIndicator.ToString()+'\n'+LCD.BlockDefinition);
}

private void log(string log){
    Echo(log);
}
