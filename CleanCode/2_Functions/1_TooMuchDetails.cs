
//bad code
public static string RenderPageWithSetupAndTeardowns(PageData pageData, bool isSuite)
{
    bool isTestPage = pageData.HasAttribute("Test");

    if (isTestPage)
    {
        var testPage = pageData.GetWikiPage();
        var newPageContent = new StringBuffer();
        IncludeSetupPages(testPage, newPageContent, isSuite);
        newPageContent.Append(pageData.GetContent());
        IncludeTeardownPages(testPage, newPageContent, isSuite);
        pageData.SetContent(newPageContent.ToString());
    }

    return pageData.GetHtml();
}

//clean code
public static string RenderPageWithSetupAndTeardowns(PageData pageData, bool isSuite)
{
    if (IsTestPage(pageData))
    {
        IncludeSetupAndTeardownPages(pageData, isSuite);
    }

    return pageData.GetHtml();
}