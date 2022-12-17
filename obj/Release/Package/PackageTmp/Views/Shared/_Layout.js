var d = document;
let userChannel = ''
async function getChannel() {
	userChannel = await setChannel()
}
getChannel()


/*显示对话窗口*/
function openBody(msgList) {
	@ {
		Session["Chat"] = true;
	}
	$('.chat-support-btn').css({
		'display': 'none'
	});
	$('.chat-main').css({
		'display': 'inline-block',
		'height': '0'
	});
	let url = window.location.href
	if (url.includes('/Home/Contact')) {
		$('.chat-main').animate({
			'height': '562px'
		})
	} else {
		$('.chat-main').animate({
			'height': '600px'
		})
	}
}
@if((bool) Session["Chat"] == true) {
	@ * < script > openBody(); < /script>*@
}


// 模拟一些后端传输数据
var serviceData = {
	'robot': {
		'chat': ['这个厉害！', '这个网站您看一下www.baidu.com', '稍等哦~', '嘿嘿', '百度一下？www.baidu.com', '嗯嗯嗯'],
	}
};
var chatMain = $('.chat-main'),
	chatHint = $('#chatHint'),
	chat_Hint = $('#chat_hint'),
	headerInfoDiv = $('.header-info-div');
chat_main = d.querySelector('.chat-main');
chatInput = d.querySelector('#chat_input'),
	chatContain = d.querySelector('#chat_contain'),
	btnOpen = d.querySelector('#btn_open'),
	btnClose = d.querySelector('#btn_close');

/*鼠标在头像上*/
$('.chat-service-img').mouseenter(
	function() {
		headerInfoDiv.fadeIn(1000);
	}
)
$('.chat-service-img').mouseleave(
	function() {
		headerInfoDiv.fadeOut();
	}
)
/*关闭对话框*/
function closeChat() {
	$('.chat-main').animate({
		'height': '0'
	});
	$('.chat-main').css({
		'display': 'none'
	});
	$('.chat-support-btn').css({
		'display': 'inline-block'
	});
}

btnOpen.addEventListener('click', async function(e) { /*点击头像打开聊天窗口*/
	e = e || window.event;

	let msgList = await getMsglist()
	console.log(msgList)


	openBody(msgList);
})

btnClose.addEventListener('click', closeChat)

/*创建新消息框*/
function createInfo(name, value,time) {
	var chatTime = new Date();
	chatTime = chatTime.toLocaleTimeString();
	var nodeP = d.createElement('p'),
		nodeSpan = d.createElement('span')
	nodeTime = d.createElement('p');
	value = value.replace(/(((ht|f)tps?):\/\/)?([A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@@[\]\':+!]*([^<>\"\"])*)/g,
		function(content) {
			return "<a href='http://" + content + "' class='chat-address' target='view_window' style='color:#6666cc '>" +
				content + '</a>';;
		});
	nodeP.classList.add('chat-' + name + '-contain');
	nodeSpan.classList.add('chat-' + name + '-text', 'chat-text');
	nodeTime.classList.add('chat-time');
	nodeSpan.innerHTML = value;
	nodeTime.innerHTML = chatTime;
	nodeP.appendChild(nodeTime);
	nodeP.appendChild(nodeSpan);
	chatContain.appendChild(nodeP);
	chatContain.scrollTop = chatContain.scrollHeight;
}
msgList.forEach(it => {
	createInfo('service', it.GContent); /*发送第一句话*/
})

var timer,
	timerId,
	flagInput = false;
shiftDown = false; // 判断是否按住shift键

function chatHintNull(chatHint) { //空输入提示
	setTimeout(function() {
		chatHint.fadeIn();
		clearTimeout(timerId);
		timer = setTimeout(function() {
			chatHint.fadeOut();
		}, 1000);
	}, 10);
	timerId = timer;
};
/*监控是否按下enter*/
function isEnter(Input, Hint, type, e) {
	e = e || window.event;
	if (e.keyCode == 16) { //按住shift键
		shiftDown = true;
	}
	if (e.keyCode == 13) {

		if (shiftDown == true) {
			shiftDown = false;
			return true;
		} else if (shiftDown == false && Input.value == '') {
			Hint();
			return true;
		} else {
			e.preventDefault();
			createInfo(type, Input.value);
			submityouText(Input.value);
			Input.value = null;
			Input.focus();

		}
	}
}

chatInput.addEventListener('keydown', function(e) { /*输入框按enter*/
	e = e || window.event;
	isEnter(chatInput, chatHintNull, 'you', e);
})

/*为按钮绑定事件*/
$('.chat-input-button').click(function() { /*消息框发送*/

	if (chatInput.value != '') {
		createInfo('you', chatInput.value);
		submityouText(chatInput.value);
		chatInput.value = null;
		chatInput.focus();

	} else {
		chatHintNull(chatHint);
	}
});
/*模拟后台消息*/
var chatSim = $('.chat-simulator'),
	sim_Text = d.querySelector('.simulator-text');
simText = $('.simulator-text');
$('.chat-service-simulator').click(
	function() {
		chatSim.fadeIn(500);
		simText.focus();
	}
);
$('.simulator-submmit').click(function() {
	if (simText.val() == '') {
		chatHintNull(chat_Hint);
	} else {
		createInfo('service', simText.val());
		simText.val('');
		simText.focus();
	}
});
/*模拟的输入框enter键判断*/
sim_Text.addEventListener('keydown', function(e) {
	e = e || window.event;
	isEnter(sim_Text, chatHintNull, 'service', e);
})
$('.simulator-close').click(function() {
	chatSim.fadeOut();
	simText.val('');
	simText.focus();
});

/*关闭按钮*/
$('.chat-close-button').click(
	function() {
		if (confirm("不再聊会儿吗？")) {
			window.close();
		} else {}
	}
);
/*按钮特效*/
var buttons = $('button');
buttons.each(function(i) {
	$(this).mouseenter(function() {
		buttons.eq(i).fadeTo('slow', 0.8);
	});
})
buttons.each(function(i) {
	$(this).mouseleave(function() {
		buttons.eq(i).fadeTo('slow', 1);
	});
})

function submityouText(text) {

	// 模拟后端回复
	var num = Math.random() * 10;
	if (num <= 7) {
		getServiceText(serviceData);
	}
}

function getServiceText(data) { /*已定义后台消息框*/
	var serviceText = data.robot.chat,
		i = Math.floor(Math.random() * serviceText.length);
	createInfo('service', serviceText[i]);
}
