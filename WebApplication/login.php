<?php
/** login.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */
	if(!isset($_SESSION)){  
		session_start();	// very important: session_start() has to be executed befor any output is shown
	}

	include ("template/header.php");
	include ("include/operations.php");
?>

<html>
	<center>
	<script src="javascript/idValidate.js"></script>
  <body>
  	<div id="container">
		<h4 class="form-header">Submit Your ID to Begin:</h4>
		<form id="idForm" method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
		 	ID: <input id="idField" type="int" name="id"><br><br>
	  		<input onclick="isValidInt()" id="idSubmit" type="button" value="Submit">
		</form>
	</div>
  </body>
  </center>
</html>


<?php 
//script to run when a post method occurs
if ($_SERVER["REQUEST_METHOD"] == "POST") {
  $id = $_POST["id"];
  $id_is_int = false;
  $id_is_valid = false;

  try {
	$db = get_connection();
  } catch(Exception $e) {
	echo "could not connect to database";
  }
  
  if(is_valid_student_id($id, $db)){
	  $id_is_valid = true;
	  $_SESSION["user_id"] = $id;
	  init_student_name($id, $db);
	  
	  die("<script>location.href = 'programSelection.php'</script>");
  } else {
	  echo "<center><div style ='color:red'width:100%>The ID 
		you submitted was not found</div></center>";
  }
}

$db=null; //close database connection

include ("template/footer.php");
?>
