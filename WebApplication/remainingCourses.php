<?php
/** remainingCourses.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */
	if(!isset($_SESSION)){
		session_start(); // very important: session_start() has to be executed befor any output is shown
	}
	if(!isset($_SESSION["user_id"])){
		die("<script>location.href = 'include/logout.php'</script>");
	}
?>

<script type="text/javascript" src="javascript/jquery.js"></script>
<script type="text/javascript" src="javascript/getRemainingCourses.js"></script>

<div id="wrapper">
	
<?php 
include ("template/header.php"); 
include ("include/operations.php"); 

try {
	$db = get_connection();
} catch(Exception $e) {
	echo "could not connect to database";
}
?>

<div id="container">
	<!--invisible division to store information used in AJAX call-->
	<div id="user_data">
		<p id="user_id"><?php echo $_SESSION["user_id"] ?></p>
		<p id="user_major"><?php echo $_SESSION["user_major"] ?></p>
		<p id="user_minor"><?php echo $_SESSION["user_minor"] ?></p>
	</div>
	<ul id="student-info">
		<li class="stu-info-item">
			<?php remaining_major_areas($_SESSION["user_id"], $_SESSION["user_major"], $db); ?></tr>
		</li>
		<li class="stu-info-item">
			<?php remaining_minor_areas($_SESSION["user_id"], $_SESSION["user_minor"], $db); ?></tr>
		</li>
	</ul>
	<center>
		<div id="courses">
			<p style="font-size:16px"><strong>Courses</strong></p>
			<!-- empty field that is used to display the courses per area -->
			<p id="returnfield" style="font-size:14px">Click on an area to show its courses</p>
		</div>
	</center>
</div>

<?php 
	include ("template/footer.php"); 
	$db=null; //close database connection
?>
</div>
