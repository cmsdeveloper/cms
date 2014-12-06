<?php
/** home.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
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
		<h3>Welcome to AUI Curriculum Management</h3>
		<p>This application will help you plan your future schedule, view your progress in your current curriculum, 
			or explore new majors and minors</p>
		<?php
			//if the user is logged in, continue will take them to program selection
			//otherwise, continue will take them to login
			if(isset($_SESSION["user_id"])) {
				echo "<p><a href=\"programSelection.php\">Continue</a></p>";
			} else {
				echo "<p><a href=\"login.php\">Continue</a></p>";
			}
		?>
	</center>
</html>

<?php include ("template/footer.php"); ?>
