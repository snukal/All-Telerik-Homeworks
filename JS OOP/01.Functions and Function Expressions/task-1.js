/* global sum */
/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/ function sum(arr) {
	var i, 
	len,
	sum = 0;
	
	if(arr === undefined) { 
		throw 'not Array'
	}
	
	len = arr.length;
	if(!arr.length) { 
		return null;
	}
	
	for(i = 0, len = arr.length; i < len; i += 1) {
	    if (isNaN(arr[i])) { 
	        throw 'Number must be of type Number';
	    }
		
		sum += +arr[i]; 
	}
	
	return sum;
	}
	module.exports = sum;
