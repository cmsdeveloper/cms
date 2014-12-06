/** getRemainingCourses.js
 * Authors:
 * 	 Ryder Huggins
 * 	 Lorenzo von Ritter
 * 
 * Al Akhawayn University
 * CSC 3326 Section 01
 * Fall 2014
 */
$(document).ready(
	function()
	{
		//disables links on table data
		$("td > a").attr("disabled", "disabled").on("click", function() {
    		return false; 
		});

		var user_id = document.getElementById("user_id").innerHTML;
		var user_major = document.getElementById("user_major").innerHTML;
		var user_minor = document.getElementById("user_minor").innerHTML;
		
		//event handler on table row click
		$('table.maj_remaining tr.degree_area').click(
			function()
			{
				//get area code from table row 
				var area_code = $(this).find("a").attr("href"); 
				//sends an AJAX POST call to return remaining courses with
				//given parameters
				//fill return field with result set
				$.post(
					"returnRemainingCourses.php?major=true", 
					{
						'user_id': user_id,
						'user_major': user_major,
						'area_code': area_code
					},
					function(returndata)
					{
						$("#returnfield").html(returndata);
					});
			});
		
		//event handler on table row click
		$('table.min_remaining tr.degree_area').click(
			function()
			{
				//get area code from table row 
				var href = $(this).find("a").attr("href"); 
				//sends an AJAX POST call to return remaining courses with
				//given parameters
				//fill return field with result set
				$.post(
					"returnRemainingCourses.php?minor=true", 
					{
						'user_id': user_id,
						'user_minor': user_minor,
						'area_code': href
					 },
					function(returndata)
					{
						$("#returnfield").html(returndata);
					});
			});
	});
