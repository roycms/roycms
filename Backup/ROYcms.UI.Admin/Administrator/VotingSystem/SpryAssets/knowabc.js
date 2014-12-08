
		


	var timer;
	var length=0;
	function _bodyonload()
	{
		timer = setInterval("setLength()" , 100);
	}
	function setLength()
	{
		var step = 4;
		length = length+step;
		var flag = 0;
		for(var i in lengthdata)
		{
			if(length <= lengthdata[i]+step)
			{
				flag = 1;
				if(length > lengthdata[i])
				{
					document.getElementById(i).style.width = lengthdata[i]+"%";
				}
				else
				{
					document.getElementById(i).style.width = length+"%";
				}
			}
		}
		if(flag == 0)
		{
			clearInterval(timer);
		}
	}
	