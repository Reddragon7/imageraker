
readme for pub

-home
http://code.google.com/p/imageraker/


1. ���� �������� ������
����üũ �� ���� ���ۿ� url ����.
������ ���̴� �� �¾� ������Ʈ ����

�׽�Ʈ�� ���̴�(pfx) ��� 
test123


2. post build event
os�� 32��Ʈ�� 64��Ʈ�Ŀ� ���� �ٸ�. ������ ��7 64��Ʈ���� ����� post build event��.
(���߿����� vs10�� ��������� ����� ����� ���� �Ʒ��� ���� vs8�� �ʿ�.)

"C:\Program Files (x86)\Microsoft Visual Studio 8\SDK\v2.0\Bin\gacutil" /if "$(TargetDir)Interop.SHDocVw.dll"
"C:\Program Files (x86)\Microsoft Visual Studio 8\SDK\v2.0\Bin\gacutil" /if "$(TargetPath)"
"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\regasm" /unregister "$(TargetPath)"
"C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727\regasm" /register "$(TargetPath)"


3. ������� ���� ie��� ���� 64��Ʈ������ �Ʒ��� ���� ����Ѵ�.

C:\Program Files (x86)\Internet Explorer\iexplore.exe



