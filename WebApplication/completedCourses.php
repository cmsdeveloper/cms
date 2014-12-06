<?php
/** completedCourses.php
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
	if(!isset($_SESSION["user_id"])){
		die("<script>location.href = 'include/logout.php'</script>");
	}
 
//if explore programs was selected, overwrite user major and minor
//session variables with the selected values
	if ($_SERVER["REQUEST_METHOD"] == "POST") {
		if (isset($_POST["selectMajor"])) {
			$_SESSION["user_major"] = $_POST["selectMajor"];
			}
		if (isset($_POST["selectMinor"])) {
			$_SESSION["user_minor"] = $_POST["selectMinor"];
			}
	}

	echo "<div id='wrapper'>";
	include ("template/header.php"); 
	include ("include/operations.php"); 

	try {
		$db = get_connection();
	} catch(Exception $e) {
		echo "could not connect to database";
	}

	echo "<div id=container>";
	echo "<h3>Your Current and Completed Courses</h3>";
	display_completed_courses($_SESSION["user_id"], $db);
?>

<p><a href="remainingCourses.php">Continue to View Remaining Courses</a></p>

</div>

<?php 
	include("template/footer.php");
	$db=null; //close database connection
?>
</div>
