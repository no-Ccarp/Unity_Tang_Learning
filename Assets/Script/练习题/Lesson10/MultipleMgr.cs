using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MultipleMgr
{
    private static MultipleMgr instance = new MultipleMgr();

    public static MultipleMgr Instance => instance;

    private Dictionary<string, Dictionary<string, Sprite>> dic = new Dictionary<string, Dictionary<string, Sprite>>();

    /// <summary>
    /// 获取Multiple图集中的某一张小图
    /// <param name= "
    /// </summary>

    private MultipleMgr()
    {

    }

    public Sprite GetSprite(string multipleName, string spriteName)
    {
        if(dic.ContainsKey(multipleName))
        {
            if (dic[multipleName].ContainsKey(spriteName))
                return dic[multipleName][spriteName];
        }
        else
        {
            //临时字典
            Dictionary<string, Sprite> dicTmp = new Dictionary<string, Sprite>();
            //动态加载图片资源
            Sprite[] sprs = Resources.LoadAll<Sprite>(multipleName);
            for (int i = 0;i < sprs.Length; i ++)
            {
                dicTmp.Add(sprs[i].name, sprs[i]);
            }

            dic.Add(multipleName, dicTmp);
            if (dicTmp.ContainsKey(spriteName))
                return dicTmp[spriteName];
        }

        return null;
    }

    public void ClearInfo()
    {
        //清空资源
        dic.Clear();
        //卸载资源
        Resources.UnloadUnusedAssets();
    }

}
