<?php
/** programSelection.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */
	if(!isset($_SESSION)){  
		session_start();	// very important: session_start() has to be executed before any output is shown
	}
	if(!isset($_SESSION["user_id"])){
		die("<script>location.href = 'include/logout.php'</script>");
	}
?>

<script src='javascript/programSelection.js'></script>
<div id="wrapper">

<?php
include ("template/header.php");
include ("include/operations.php");

try {
	$db = get_connection();
} catch(Exception $e) {
	echo "could not connect to database";
}

//get student majors and minors
$stuMajArray = get_student_majors($_SESSION["user_id"], $db);
$stuMinArray = get_student_minors($_SESSION["user_id"], $db);

$stuMajLen = count($stuMajArray);
$stuMinLen = count($stuMinArray);

?>
<html>
	<div id="container">
		<div id="current">
			<ul id="student-info">
				<li class="stu-info-item">
					<table border="1">
						<tr><th>Student ID</th><th>Name</th></tr>
						<?php
							//create a table with the user's id and name 
							begin_row();
							begin_data();
							echo $_SESSION["user_id"];
							end_data();
							begin_data();
							echo $_SESSION["user_first_name"]. " " .$_SESSION["user_last_name"];
							end_data();
							end_row();
						?>
					</table>
				</li>
				<li class=\"stu-info-item\">
					<table border=\"1\">
						<tr><th>Major</th></tr>
						<?php
						//create a table with the user's major 
							for($i=0;$i<$stuMajLen;$i++){
							begin_row();
							begin_data();
							echo $stuMajArray[$i][1];
							end_data();
							end_row();
						}
						?>
					</table>
				</li>
				<li class=\"stu-info-item\">
					<table border=\"1\">
						<tr><th>Minor</th></tr>
						<?php
						//create a table with user's minor
							for($i=0;$i<$stuMinLen;$i++){
							begin_row();
							begin_data();
							echo $stuMinArray[$i][1];
							end_data();
							end_row();
						}?>
					</table>
				</li>
			</ul>						
			<br>
		</div>
		<div id="selection">
			<!--Radio buttons to select current or explore programs-->
			<form id="selectionForm" method="post" action="completedCourses.php">
				<input onclick="currentClicked()" type="radio" name="program" value="current">Your Current Programs
				<br>
				<input onclick="exploreClicked()" type="radio" name="program" value="explore">Explore Programs
			</form>
			<form id="exploreForm" method="post" action="completedCourses.php">
		 			<?php 
						//creates the combo-box for major selection
						select_major($db)
				  	?><br>
				  	<?php 
						//creates the combo-box for minor selection
						select_minor($db)
				  	?>			  	
			</form>
			<button id="selectionSubmit" type="button" onclick="selectionSubmit()" disabled>Continue</button>
		</div>
	</div>
</html>

<?php 
	include ("template/footer.php"); 
	$db=null; //close database connection
?>
</div>
