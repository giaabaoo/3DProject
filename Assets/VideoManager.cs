using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
public class VideoManager : MonoBehaviour
{
   public VideoPlayer vid;

   public void Play() {
       vid.Play();
   }

   public void Stop() {
       vid.Stop();
   }
}
