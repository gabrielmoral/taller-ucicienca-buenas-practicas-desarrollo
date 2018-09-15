void RenderBanner()
{
    if ((platform.ToUpper().IndexOf("MAC") > -1) &&
         (browser.ToUpper().IndexOf("IE") > -1) &&
         resize > 0)
    {
        // do something
    }
}



void RenderBanner()
{
    bool isMacOs = platform.ToUpper().IndexOf("MAC") > -1;
    bool isIE = browser.ToUpper().IndexOf("IE") > -1;
    bool wasResized = resize > 0;

    if (isMacOs && isIE && wasResized)
    {
        // do something
    }
}