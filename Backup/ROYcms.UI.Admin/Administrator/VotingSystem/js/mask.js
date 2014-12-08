function maskReady(){
	var each = function(a, b) {for (var i = 0, len = a.length; i < len; i++) b(a[i], i);};
	// 事件绑定
	var bind = function (obj, type, fn){
		if (obj.attachEvent) {
			obj['e' + type + fn] = fn;
			obj[type + fn] = function(){obj['e' + type + fn](window.event);}
			obj.attachEvent('on' + type, obj[type + fn]);
		}
		else{
			obj.addEventListener(type, fn, false);
		};
	};
	// 移除事件
	var unbind = function (obj, type, fn) {
		if (obj.detachEvent) {
			try {
				obj.detachEvent('on' + type, obj[type + fn]);
				obj[type + fn] = null;
				}
			catch(_){};
		}
		else{
			obj.removeEventListener(type, fn, false);
		};
	};
	// 阻止浏览器默认行为
	var stopDefault = function(e){
		e.preventDefault ? e.preventDefault() : e.returnValue = false;
	};
	// 获取页面滚动条位置
	var getPage = function(){
		var dd = document.documentElement,
		db = document.body;
		return {
			left: Math.max(dd.scrollLeft, db.scrollLeft),
			top: Math.max(dd.scrollTop, db.scrollTop)
		};
	}; 
	// 锁屏
	var lock = {
		show: function(){
			$('.lightbox').show();
			var p = getPage(),left = p.left,top = p.top;   
			// 页面鼠标操作限制
			this.mouse = function(evt){
				var e = evt || window.event;
				stopDefault(e);
				scroll(left, top);
			};
			each(['DOMMouseScroll', 'mousewheel', 'scroll', 'contextmenu'], function(o, i) {
				bind(document, o, lock.mouse);
			});
			// 屏蔽特定按键: F5, Ctrl + R, Ctrl + A, Tab, Up, Down
			this.key = function(evt){
				var e = evt || window.event,key = e.keyCode;
				if((key == 116) || (e.ctrlKey && key == 82) || (e.ctrlKey && key == 65) || (key == 9) || (key == 38) || (key == 40)) {
					try{e.keyCode = 0;}
					catch(_){};
					stopDefault(e);
				};
			};
			bind(document, 'keydown', lock.key);
		},
		close: function(){
			$('.lightbox').hide();
			each(['DOMMouseScroll', 'mousewheel', 'scroll', 'contextmenu'], function(o, i) {
				unbind(document, o, lock.mouse);
			});
			unbind(document, 'keydown', lock.key);
		}
	};
	$('#btn_lock').click(function (){
		lock.show();
		$(".tanchuang_wrap").show();
	})
	$(".close_tc").click(function(){lock.close();$(".tanchuang_wrap").hide();});
}
$(document).ready(function(){
	maskReady(); 
	function addClass(){$(this).addClass("hover");}
	function removeClass(){$(this).removeClass("hover");}
	$(".close_tc").hover(addClass,removeClass);

});