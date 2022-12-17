let baseUrl = 'http://localhost:52518/api/'
//let baseUrl = 'http://192.168.2.22:44362/api/'

let apiHandle = {
	getmac: 'gmile/getmac', //获取MAX地址
	msglist: 'gmile/msglist', //获取聊天记录
	msgread: 'gmile/addmsg', //客户端发送消息
}


async function requestGet(url, params = {}) {
	let newurl = `${baseUrl}${apiHandle[url]}`
	// console.log(params)
	let res = await axios(newurl, {
		params
	})
	// console.log(res) 
	let data = res.data

	if (res.status === 200) {
		if (data.IsSuccess) {
			return {
				isOK: true,
				data: data.Data
			}
		} else {
			// alert('网络环境出错，无法在线沟通')
			return {
				isOK: false,
				data: data.Data
			}
		}
	} else {
		// alert('网络环境出错，无法在线沟通')
		return {
			isOK: false,
			data: data.Data
		}
	}
}

async function getMsglist() {
	let serverip = getLocalSt('userChannel')
	let res = await requestGet('msglist', {
		// fromip:ip,
		// toip:'serveAdmain',
		serverip
	})
	if (res.isOK) {
		return res.data.reverse()
	} else {
		return []
	}
}


async function sendMsg(content) {
	let userip = getLocalSt('userChannel')
	let res = await requestGet('msgread', {
		userip,
		serverip: 'serveAdmain',
		content,
		isserver: false
	})
	if (res.isOK) {
		return res
	} else {
		return []
	}
}






function setLocalSt(key, value) {
	localStorage.setItem(key, JSON.stringify(value));
}

function getLocalSt(key) {
	return JSON.parse(localStorage.getItem(key));
}

function removeLocalSt(key) {
	localStorage.removeItem(key);
}


async function setChannel() {
	let hasUerChannel = true
	let userChannel = getLocalSt('userChannel')
	if (userChannel === null) {
		hasUerChannel = false
	}
	if (userChannel === '') {
		hasUerChannel = false
	}
	if (!hasUerChannel) {
		let res = await requestGet('getmac')
		if (res.isOK) {
			let channel = `channel_${res.data}`
			setLocalSt('userChannel', channel)
			return channel
		}
	} else {
		return userChannel
	}

}









function GetDate(t) {
	function checkAddZone(num) {
		return num < 10 ? '0' + num.toString() : num
	}

	function dateTimeFormatter(t) {
		if (!t) return ''
		t = new Date(t).getTime()
		t = new Date(t)
		var year = t.getFullYear()
		var month = (t.getMonth() + 1)
		month = checkAddZone(month)

		var date = t.getDate()
		date = checkAddZone(date)

		var hour = t.getHours()
		hour = checkAddZone(hour)

		var min = t.getMinutes()
		min = checkAddZone(min)

		var se = t.getSeconds()
		se = checkAddZone(se)

		return year + '-' + month + '-' + date + '  ' + hour + ':' + min 
	}

	let time = t.split('(')[1].split(')')[0] * 1;

	return dateTimeFormatter(time)
}





function clearMsgList(){
	let chat_contain = document.getElementById('chat_contain')
	chat_contain.innerHTML = ''
}