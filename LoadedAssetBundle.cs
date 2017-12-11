using System;
using UnityEngine;

namespace AssetBundles
{
  /// <summary>
  /// Loaded assetBundle contains the references count which can be used to 
  /// unload dependent assetBundles automatically.
  /// </summary>
  public class LoadedAssetBundle
  {
    public AssetBundle m_AssetBundle;
    public int m_ReferencedCount;

    public LoadedAssetBundle(
      AssetBundle assetBundle)
    {
      m_AssetBundle = assetBundle;
      m_ReferencedCount = 1;
    }
  }
}
