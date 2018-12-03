# RayaTahan.Report
ابزار ایجاد گزارش برای پروژه‌های دات‌نت 

## نصب
برای استفاده از این ابزار می‌توانید از طریق نصب ناگت آن اقدادم کنید.

    PM> Install-Package RayaTahan.Report

    
## استفاده 

	Dim CustomCSS As String = "h2 {color:#405060}"
	Dim AllPages As String = ""
	AllPages += RayaTahan.Report.HTMLParser.GeneratePage("<h2>عنوان الف</h2>")
	AllPages += RayaTahan.Report.HTMLParser.GeneratePage("<h2>عنوان ب</h2>")
	AllPages += RayaTahan.Report.HTMLParser.GeneratePage("<h2>عنوان ج</h2>")

	Dim HTMLData As String = RayaTahan.Report.HTMLParser.GenerateHTML(AllPages, "عنوان گزارش", CustomCSS)
