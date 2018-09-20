
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

private static bool IsTestPage(PageData pageData)
{
    return pageData.HasAttribute("Test");
}

private static void IncludeSetupAndTeardownPages(PageData pageData, bool isSuite)
{
    var testPage = pageData.GetWikiPage();
    var newPageContent = new StringBuffer();
    IncludeSetupPages(testPage, newPageContent, isSuite);
    newPageContent.Append(pageData.GetContent());
    IncludeTeardownPages(testPage, newPageContent, isSuite);
    pageData.SetContent(newPageContent.ToString());
}