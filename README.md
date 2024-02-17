# TellMyFriends

A tool for automating sending personalized WhatsApp messages - for both Mac and Windows
This is a simple, semi-manual tool, not requiring a WhatsApp business account or API.
Its Mac version uses Apple Script Editor with some JavaScript code, and its Windows version is written using VB.Net.

It requires the user to be at their computer and click the send button for each recipient, but given the tool automates starting a chat in WhatsApp Web, filling in the recipient phone number, and the personalized text,
it greatly reduce the work required...

You can create multiple templates - one per segment or type of recipient - for example, one for family, one for friends, and one for work colleagues.
Each template can use the word FNAME as a place holder for the recipient name - the tool will replace that before sending the message to the user.

The recipient list is stored in CSV file having three columns like that (see also the sample data files folder):

name,phone,template
Jack,12123334444,template1.txt
Jill,12123335555,template2.txt

More Information on this project is available on my blog at:

1. Mac: https://www.srooltheknife.com/2024/02/automating-whatsapp-using-applescript.html
2. Windows: https://www.srooltheknife.com/2024/02/automating-whatsapp-part-2-on-windows.html
