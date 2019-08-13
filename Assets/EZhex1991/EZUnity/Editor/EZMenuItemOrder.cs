/* Author:          ezhex1991@outlook.com
 * CreateTime:      2019-07-11 19:36:24
 * Organization:    #ORGANIZATION#
 * Description:     
 */
namespace EZhex1991.EZUnity
{
    public enum EZMenuItemOrder
    {
        /// <summary>
        /// Default MenuItem Order
        /// </summary>
        _Section_0 = 10000,

        /// <summary>
        /// Application
        /// </summary>
        _Section_1 = _Section_0 + 100,
        ApplicationSettings,
        OpenPersistentFolder,
        ClearPersistentFolder,
        PlayerPrefsEditor,

        /// <summary>
        /// Asset Manager
        /// </summary>
        _Section_2 = _Section_0 + 200,
        SaveAssets,
        RefreshAssetDatabase,
        Renamer,

        /// <summary>
        /// Viewer
        /// </summary>
        _Section_3 = _Section_0 + 300,
        AssetBundleManager,
        AssetReferenceViewer,
        CorrespondingObjectViewer,
        FontReferenceViewer,

        /// <summary>
        /// Helper
        /// </summary>
        _Section_4 = _Section_0 + 400,
        GuidGenerator,
        RegexTester,
        ColorBlender,
        TimePanel,

        _Section_5 = _Section_0 + 500,

        _Section_6 = _Section_0 + 600,

        _Section_7 = _Section_0 + 700,

        /// <summary>
        /// XLuaExtension
        /// </summary>
        _Section_8 = _Section_0 + 800,
        LuaToTxt,
        ClearLuaTextFolder,

        /// <summary>
        /// Experimental
        /// </summary>
        _Section_9 = _Section_0 + 900,
        ShaderKeywordManager,
    }
}