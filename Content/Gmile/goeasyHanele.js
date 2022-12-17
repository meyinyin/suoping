let goeasy = {}

function createdGoEasy(fun) {//创建goeasy 并且建立连接
	let userId = getLocalSt('userChannel')
	goeasy = GoEasy.getInstance({
		host: 'hangzhou.goeasy.io', //应用所在的区域地址: 【hangzhou.goeasy.io |singapore.goeasy.io】
		appkey: "BC-f07b49654a344ba1be2f98eb50913820" //替换为您的应用appkey
	});
	goeasy.connect({
		userId,
		onSuccess: function() { //连接成功
			console.log("GoEasy connect successfully.") //连接成功
			let channel = userId
			receiveImMsg(channel,fun)
		},
		onFailed: function(error) { //连接失败
			console.log("Failed to connect GoEasy, code:" + error.code + ",error:" + error.content);
		},
		onProgress: function(attempts) { //连接或自动重连中
			console.log("GoEasy is connecting", attempts);
		}
	});
}

function receiveImMsg(channel, fun) { // 接收信息并进行后部操作
	goeasy.subscribe({
		channel, //替换为您自己的channel
		onMessage: function(message) {
			let messageInfo = JSON.parse(message.content)
			fun(messageInfo)
		},
		onSuccess: function() {
			console.log("Channel订阅成功。");
		},
		onFailed: function(error) {
			console.log("Channel订阅失败, 错误编码：" + error.code + " 错误信息：" + error.content)
		}
	});
}

function disconnectGoEasy() {//断开连接
	goeasy.disconnect({
		onSuccess: function() {
			console.log("GoEasy disconnect successfully.")
		},
		onFailed: function(error) {
			console.log("Failed to disconnect GoEasy, code:" + error.code + ",error:" + error.content);
		}
	});
}

function publish(message,channel = 'SUOPINGALLMSGCHANNEL'){
	goeasy.publish({
	    channel,//替换为您自己的channel
	    message,//替换为您想要发送的消息内容
	    onSuccess:function(){
	        console.log("消息发布成功。");
	    },
	    onFailed: function (error) {
	        console.log("消息发送失败，错误编码："+error.code+" 错误信息："+error.content);
	    }
	});
}







function reconnectGoEasy(fun){//重连
	createdGoEasy(fun)
}

