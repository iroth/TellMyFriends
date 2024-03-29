JsOsaDAS1.001.00bplist00�Vscript_�
ObjC.import('Foundation')

const readFileEnc = function (path, encoding) {
    !encoding && (encoding = $.NSUTF8StringEncoding)

    const fm = $.NSFileManager.defaultManager
    const data = fm.contentsAtPath(path)
    const str = $.NSString.alloc.initWithDataEncoding(data, encoding)
    return ObjC.unwrap(str)
}

const parseCSV = function (input) {
	const rows = input.split("\n");
	var recipients = []
	var i = 0;
	for (const row of rows) {
		i = i + 1;
		if (i === 1) continue;
		const fields = row.split(',');
		recipients.push({
			name: fields[0],
			phone: fields[1],
			template: fields[2]
			});
		
	}
	return {recipients: recipients};
}


const sendOneMessage = function (chromeapp, window, url) {

 var ic = window.tabs.length;
 window.tabs.push(new chrome.Tab());
  window.tabs[1].url = url;
  while (window.tabs.length > ic) {
  	this.console.log("waiting...");
  }
}

var app = Application("Script Editor");
app.includeStandardAdditions = true;
var folder = app.chooseFolder({ withPrompt: 'Please select the data foler' })
var file = folder + "/data.csv";
var dataStr = readFileEnc(file)
// var data = JSON.parse(dataStr);
var data = parseCSV(dataStr);

var chrome = Application('Google Chrome');
var window = chrome.Window().make();
var countDoc = 0;

for (var i = 0 ; i < data.recipients.length ; i++) {
	var tfile = folder + "/" + data.recipients[i].template;
	var text = readFileEnc(tfile);
	text = encodeURIComponent(text.replace(/FNAME/g, data.recipients[i].name));
	var dest_url = "https://web.whatsapp.com/send/?phone=" + data.recipients[i].phone + "&text=" + text + "&type=phone_number";
	sendOneMessage(chrome, window, dest_url);
	countDoc++;
}

window.close();

countDoc

                              � jscr  ��ޭ