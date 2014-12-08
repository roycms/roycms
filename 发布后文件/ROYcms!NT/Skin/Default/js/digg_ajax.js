/* 
*需要结合jquery和liger ui一起使用
----------------------------------------------------------*/
//提交顶踩AJAX处理
function diggAdd(urlPath, digg_type, article_id) {
	//移除绑定事件
	$('#digg_good').unbind("click");
	$('#digg_bad').unbind("click");
	//alert(article_id);
	//提交操作
	$.ajax({
		type: 'post',
		dataType: 'json',
		url: urlPath + 'tools/submit_ajax.ashx?action=digg_add',
		data: {
			digg_type: function() {
				return digg_type;
			},
			article_id: function() {
                	return article_id;
			}
		},
		timeout: 20000,
		success: function(data, textStatus) {
			if (data.msg == 1) {
				//计算赞成百分比
				var diggCountNum = data.digggood + data.diggbad;
				$('#digg_good .digg_num').text('(' + data.digggood + ')');
				var goodPercentage = (parseFloat(data.digggood) / parseFloat(diggCountNum) * 100).toFixed(1);
				$('#digg_good .digg_percent_bar span').width(goodPercentage);
				$('#digg_good .digg_percent_num').text(goodPercentage + '%');
				
				//计算反对百分比
				$('#digg_bad .digg_num').text('(' + data.diggbad + ')');
				var badPercentage = (parseFloat(data.diggbad) / parseFloat(diggCountNum) * 100).toFixed(1);
				$('#digg_bad .digg_percent_bar span').width(badPercentage);
				$('#digg_bad .digg_percent_num').text(badPercentage + '%');
			} else {
				//alert(data.msgbox);
				$.ligerDialog.warn(data.msgbox);
			}
		},
		error: function (XMLHttpRequest, textStatus, errorThrown) {
			//alert('状态：' + textStatus + '；出错提示：' + errorThrown);
			$.ligerDialog.error('状态：' + textStatus + '；出错提示：' + errorThrown);
		} 
	});
	return false;
}
//绑定按钮事件
function bindDigg(urlPath, article_id){
	$('#digg_good').bind('click',function(){
		diggAdd(urlPath, 'good', article_id);
	});
	$('#digg_bad').bind('click',function(){
		diggAdd(urlPath, 'bad', article_id);
	});
}