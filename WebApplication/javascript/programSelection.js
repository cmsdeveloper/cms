/** programSelection.js
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */

var explore = 0;

//executed when explore program radio button is selected
//shows major and minor combo-boxes
function exploreClicked() {
	document.getElementById("selectionSubmit").disabled = false;
	document.getElementById("exploreForm").style.display = 'block';
	explore = 1;
}

//executed when explore program radio button is selected
//hides major and minor combo-boxes
function currentClicked() {
	document.getElementById("selectionSubmit").disabled = false;
	document.getElementById("exploreForm").style.display = 'none';
	explore = 0;
}

//executed when continue button is clicked
function selectionSubmit() {
	//if explore radio button is selected, submit the selected values
	//else continue with current programs
	if(explore==1) {
		document.forms["exploreForm"].submit();
	} else {
		document.forms["selectionForm"].submit();
	}
}

//submit explore major and minor values
function exploreSubmit() {
	document.forms["exploreForm"].submit();
}
