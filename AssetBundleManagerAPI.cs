using System;

namespace AssetBundles
{
  public class AssetBundleManagerAPI : IAssetBundleManagerAPI
  {
    static AssetBundleManagerAPI()
    {
      AssetBundleManager.SetSourceAssetBundleURL("http://192.168.0.101:7888/");
      AssetBundleManager.Initialize();
    }

    void IAssetBundleManagerAPI.LoadAssetAsync<TAsset>(
      string assetBundleName,
      string assetName,
      Action<TAsset> onLoad)
    {
      AssetBundleManager.instance.LoadAssetAsync<TAsset>(
        assetBundleName, assetName, onLoad);
    }
  }
}
