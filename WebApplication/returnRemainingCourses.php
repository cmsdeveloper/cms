<!-- 
/** remainingCourses.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */ -->
 <?php
	include ("include/operations.php");

	try {
		$db = get_connection();
	} catch(Exception $e) {
		echo "could not connect to database";
	};
	
	//called by AJAX when clicking on major area row
	if(isset($_GET['major'])){
		remaining_major_courses($db, $_POST['user_id'], $_POST['user_major'], $_POST["area_code"]);
	}
	
	//called by AJAX when clicking on minor area row
	else if(isset($_GET['minor'])){	
		remaining_minor_courses($db, $_POST['user_id'], $_POST['user_minor'], $_POST['area_code']);
	}
?>
