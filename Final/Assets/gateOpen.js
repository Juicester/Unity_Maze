// Smothly open a hinge
var smooth = 2.0;
var HingeOpenAngle = 90.0;
private var open : boolean;
private var enter : boolean;

private var defaultRot : Vector3;
private var openRot : Vector3;

function Start(){
defaultRot = transform.eulerAngles;
openRot = new Vector3 (defaultRot.x, defaultRot.y + HingeOpenAngle, defaultRot.z);
}

//Main function
function Update (){
if(open){
//Open hinge
transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, openRot, Time.deltaTime * smooth);
}else{
//Close hinge
transform.eulerAngles = Vector3.Slerp(transform.eulerAngles, defaultRot, Time.deltaTime * smooth);
}

if(Input.GetKeyDown("f") && enter ){

open = !open;
}
}

function OnGUI(){
if(enter){
GUI.Label(new Rect(Screen.width/2 - 75, Screen.height - 100, 150, 30), "Press 'F' to open the gate");
}
}

//Activate the Main function when player is near the gate
function OnTriggerEnter (other : Collider){
if (other.gameObject.tag == "Player") {
	
enter = true;
}
}

//Deactivate the Main function when player is go away from gate
function OnTriggerExit (other : Collider){
if (other.gameObject.tag == "Player") {
enter = false;
}
}