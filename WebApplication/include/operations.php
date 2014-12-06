<!-- /** operations.php
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 *
 * This file contains functions needed for dynamic content generation and 
 * database i/o
 */ -->
<?php

include ("include/connection.php");

/** is_valid_student_id is a function that will query the database 
 * to check if the student id entered in the id form is valid. Before 
 * the database is queried, the submitted value must pass the validate_id 
 * method to test if it is a valid integer.
 * 
 * @param: $stu_id - input from the id form, validated as an int by the 
 *   validate_id function
 * @return: boolean representing whether or not the student id exists in the 
 *   database
 */
function is_valid_student_id($id, $database){
	$valid = false;
	try {
		$result = $database->query("select count(*) from Student where stu_id=$id");
	} catch(Exception $e){
		echo "could not run query";
		$valid = false;
	}
	$resultSet = $result->fetch(PDO::FETCH_NUM);
	$idCount = $resultSet[0];
	if($idCount == 1) {
		$valid = true;
	} else {
		$valid = false;
	}
	return $valid;
}

/** function get_student_majors
 * 
 * @param: $id - the user's student id
 * @param: $connect - database connection
 * @return: $$majArray - an array with the title of each major 
 * 				the student is enrolled in
 */
function get_student_majors($id, $db){
	try {
	$majResult = $db->query("select M.maj_code, maj_title
		from Major M, StudentMajor SM, Student S
		where S.stu_id = $id
		  and S.stu_id = SM.stu_id
		  and SM.maj_code = M.maj_code");
	} catch(Exception $e){
		echo "could not run query";
	}
	$majResultSet = $majResult->fetchAll(PDO::FETCH_NUM);
	$_SESSION["user_major"] = $majResultSet[0][0];
	return $majResultSet;
}

/** function get_student_minors
 * 
 * @param: $id - the user's student id
 * @param: $connect - database connection
 * @return: $$minArray - an array with the title of each major 
 * 				the student is enrolled in
 */
function get_student_minors($min_fun_id, $db){
	try {
	$minResult = $db->query("select M.min_code, min_title
		from Minor M, StudentMinor SM, Student S
		where S.stu_id = $min_fun_id
		  and S.stu_id = SM.stu_id
		  and SM.min_code = M.min_code");
	} catch(Exception $e){
		echo "could not get student's programs";
	}
	$minResultSet = $minResult->fetchAll(PDO::FETCH_NUM);
	$_SESSION["user_minor"] = $minResultSet[0][0];
	return $minResultSet;
}
/** function get_student_name
 * returns an array with the first value being the student's first
 * name, the second value being the students last name
 * 
 */
function init_student_name($id, $db){
	try {
	$result = $db->query(
		"select stu_fname, stu_lname
		from Student
		where stu_id = $id");
	} catch(Exception $e) {
		echo "could not get student's name";
	}
	$resultSet = $result->fetch(PDO::FETCH_NUM);
	$_SESSION["user_first_name"] = $resultSet[0];
	$_SESSION["user_last_name"] = $resultSet[1];
}
/** function select_major
 * generates the combo-box for selecting a major in the Explore Programs
 * page
 */ 
function select_major($db){
	$query = "SELECT maj_code, maj_title FROM Major";
	echo "Major: <select id='selectMajor' name='selectMajor'>";
	try {
		foreach ($db->query($query) as $row) {
			echo "<option value='".$row["maj_code"]."'>".$row["maj_title"]."</option>";
		}
	} catch (Exception $e) {
		echo "unable to retrieve majors";
	}
	echo "</select>";
}

/** function select_major
 * generates the combo-box for selecting a minor in the Explore Programs
 * page
 */ 
function select_minor($db){
	$query = "SELECT min_code, min_title FROM Minor";
	echo "Minor: <select id='selectMinor' name='selectMinor'>";
	try {
		foreach ($db->query($query) as $row) {
			echo "<option value='".$row["min_code"]."'>".$row["min_title"]."</option>";
		}
	} catch (Exception $e) {
		echo "unable to retrieve majors";
	}
	echo "</select>";
}

/** function display_completed_courses
 * generates a table with all of the courses which a student has completed or is
 * currently enrolled
 */
function display_completed_courses($id, $db) {
	$query = "select C.crs_code, C.crs_title, C.crs_credits
		from Enroll E, Course C
		where E.stu_id = $id
		  and C.crs_code = E.crs_code";
	echo "<table border=\"1\"><tr><th>Course Code</th><th>Course Title</th>
		<th>Course Credits</th></tr>";
	try {
		foreach ($db->query($query) as $row) {
			begin_row();
			begin_data();
			echo $row["crs_code"];
			end_data();
			begin_data();
			echo $row["crs_title"];
			end_data();
			begin_data();
			echo $row["crs_credits"];
			end_data();
			end_row();
		}
	} catch(Exception $e) {
		echo "unable to get student's completed courses";
	}
	echo "</table>";
}

/** function remaining_major_areas
 * generates a table with the required areas for the selected major. Includes
 * whether or not the student has completed this area, and how many credits are
 * missing
 */ 
function remaining_major_areas($id, $maj, $db) {
	$query = "CALL p_maj_areareq(?, ?)";
	try {
		$stmt = $db->prepare($query);
		if (!$stmt->execute([$id, $maj])){
			echo "SQL Error: " . $stmt->errorInfo();
		}
		echo "<table class='maj_remaining' border='1' style='margin: 20px 20px 10px 5px'>\n";
		echo "<tr><th id='area_code' style='width:75px'>Area Code</th><th style='width:300px'>Major Area Title</th><th style='width:50px'>Completed</th><th style='width:50px'>Missing Credits</th></tr>\n";
	
		$creditsRemaining = 0;
		foreach($stmt->fetchAll() as $row){
			echo ("<tr class='degree_area'><td id='area_code'><a href=".$row[0].">".$row[0]."</a></td><td>".$row[1]."</td><td>".$row[2]."</td><td>".$row[3]."</td></tr>\n");
			if($row[3]>0){
				$creditsRemaining = $creditsRemaining + $row[3];
			}
		}
		echo "</table>";
		echo "<p>Total Major Credits Remaining: ".$creditsRemaining."</p>";
	} catch (Exception $e) {
		echo "unable to retrieve major area information";
	}
}

/** function remaining_minor_areas
 * generates a table with the required areas for the selected minor. Includes
 * whether or not the student has completed this area, and how many credits are
 * missing
 */
function remaining_minor_areas($id, $min, $db) {
	$query = "CALL p_min_areareq(?, ?)";
	try {
		$stmt = $db->prepare($query);
		if (!$stmt->execute([$id, $min])){
			echo "SQL Error: " . $stmt->errorInfo();
		}
		echo "<table class='min_remaining' border='1' style='margin: 20px 20px 10px 5px'>\n";
		echo "<tr><th id='area_code' style='width:75px'>Area Code</th><th style='width:300px'>Minor Area Title</th><th style='width:50px'>Completed</th><th style='width:50px'>Missing Credits</th></tr>\n";
	
		$creditsRemaining = 0;
		foreach($stmt->fetchAll() as $row){
			echo ("<tr class='degree_area'><td id='area_code'><a href=".$row[0].">".$row[0]."</a></td><td>".$row[1]."</td><td>".$row[2]."</td><td>".$row[3]."</td></tr>\n");
			if($row[3]>0) {
				$creditsRemaining = $creditsRemaining + $row[3];
			}
		}
		echo "</table>";
		echo "<p>Total Minor Credits Remaining: ".$creditsRemaining."</p>";
	} catch (Exception $e) {
		echo "unable to retrieve minor area information";
	}
}

/**function remaining_major_courses
 * returns the list of required courses for the given area of the given major.
 * also includes whether or not the student has completed the course
 */ 
function remaining_major_courses($db, $id, $major, $area) {
	$query = "CALL p_maj_areacoursereq(?, ?, ?)";
	try {
		$stmt = $db->prepare($query);
		if (!$stmt->execute(array($id, $major, $area))){
			echo "SQL Error: " . $stmt->errorInfo();
		}
		echo "<table id='".$area."_remaining' class='area_remaining' border='1'>\n";
		echo "<tr><th style='width:100px'>Course Code</th><th style='width:300px'>Course Title</th><th style='width:75px'>Credits</th><th style='width:100px'>Completed</th></tr>\n";
	
		foreach($stmt->fetchAll() as $row){
				echo ("<tr id='".$row[0]."' class='area_course'><td>".$row[0]."</td><td>".$row[1]."</td><td>".$row[2]."</td><td>".$row[3]."</td></tr>\n");
		}
		echo "</table>";
	} catch (Exception $e) {
		echo "unable to retrieve courses for selected area";
	}
}

/**function remaining_minor_courses
 * returns the list of required courses for the given area of the given minor.
 * also includes whether or not the student has completed the course
 */ 
function remaining_minor_courses($db, $id, $minor, $area) {
	$query = "CALL p_min_areacoursereq(?, ?, ?)";
	try {
		$stmt = $db->prepare($query);
		if (!$stmt->execute(array($id, $minor, $area))){
			echo "SQL Error: " . $stmt->errorInfo();
		}
		echo "<table id='".$area."_remaining' class='area_remaining' border='1'>\n";
		echo "<tr><th style='width:100px'>Course Code</th><th style='width:300px'>Course Title</th><th style='width:75px'>Credits</th><th style='width:100px'>Completed</th></tr>\n";
	
		foreach($stmt->fetchAll() as $row){
				echo ("<tr id='".$row[0]."' class='area_course'><td>".$row[0]."</td><td>".$row[1]."</td><td>".$row[2]."</td><td>".$row[3]."</td></tr>\n");
		}
		echo "</table>";
	} catch (Exception $e) {
		echo "unable to retrieve courses for selected area";
	}
}

/** the following functions are used to begin and end table rows and 
 * record values in an html table.
 */
function begin_row() {
	echo "<tr>";
}

function end_row() {
    echo "</tr>" . "\n";
}

function begin_data() {
	echo "<td>";
}

function end_data() {
	echo "</td>";
}

?>
