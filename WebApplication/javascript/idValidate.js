/** idValidate.js
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */
//checks if the submitted text is a 5-digit integer
//alerts user if input not valid
function isValidInt() {
	var id = document.getElementById("idField").value;
	if(id>9999&&id<99999) {
		document.getElementById("idForm").submit();
	} else {
		alert("Please enter a valid ID value");
	}
}
