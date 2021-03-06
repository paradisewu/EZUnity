/* Author:          ezhex1991@outlook.com
 * CreateTime:      2019-08-15 20:51:32
 * Organization:    #ORGANIZATION#
 * Description:     
 */
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace EZhex1991.EZUnity.Playables
{
    [TrackBindingType(typeof(Renderer))]
    [TrackClipType(typeof(EZMaterialColorPropertyClip))]
    public class EZMaterialColorPropertyTrack : TrackAsset
    {
        [EZLockedFoldout]
        public EZMaterialColorPropertyMixer template;

        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            return ScriptPlayable<EZMaterialColorPropertyMixer>.Create(graph, template, inputCount);
        }

        public override void GatherProperties(PlayableDirector director, IPropertyCollector driver)
        {
            var binding = director.GetGenericBinding(this) as Renderer;
            if (binding == null) return;
            driver.AddFromComponent(binding.gameObject, binding);
            base.GatherProperties(director, driver);
        }
    }
}
