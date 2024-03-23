    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EscapeCanvasController : MonoBehaviour
    {
        // Add any new canvas references here
        public GameObject welcomeCanvas;
        public GameObject retrieveGoBagCanvas;
        public GameObject mainBreakerCanvas;
        public GameObject goOutCanvas;
        public GameObject doorJamCanvas;
        public GameObject roofTop;
        public GameObject pryBarCanvas;
        public GameObject breakWindowCanvas;
        public GameObject searchGoBagCanvas;
        public GameObject welldoneCanvas;
        public GameObject circlePointCanvas;
        public GameObject successCanvas;
        public GameObject failedCanvas;
        public GameObject DeathCanvas;
        public MessageCanvas messageCanvas;
        public float switchDelayWelcome = 15f;
    

        // Add the switch delay for the RetrieveGoBagCanvas
        public float switchDelayRetrieveGoBag = 10f;
        public BoxCollider roomBarrierCollider1;
        public BoxCollider roomBarrierCollider2;
        public BoxCollider roomBarrierCollider3;
        public BoxCollider roomBarrierCollider4;

        public AudioSource soundAlarm; // Reference to the GameObject with AudioSource for the sound alarm
        private AudioSource alarmAudioSource; // Reference to the AudioSource component
        public float fadeOutDuration = 2f;
        public AudioSource goOutAudioSource;
        public float goOutSoundDuration = 10f;
   


        public WaterLevelController waterLevelController;

        private void Start()
        {
            // Ensure the welcome canvas starts in the desired state
            ShowWelcomeCanvas();
            alarmAudioSource = soundAlarm.GetComponent<AudioSource>();
            // Start the coroutine to switch canvases after a delay
            StartCoroutine(SwitchCanvasAfterDelay());
            goOutAudioSource = goOutCanvas.GetComponent<AudioSource>();
        
    }

        // Add any new canvas show functions here
        private void ShowWelcomeCanvas()
        {
            welcomeCanvas.SetActive(true);
            retrieveGoBagCanvas.SetActive(false);
            goOutCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            pryBarCanvas.SetActive(false);
            roofTop.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);

        if (alarmAudioSource != null)
            {
                alarmAudioSource.Play();
                StartCoroutine(FadeOutSoundAndSwitchCanvas());
            }

            messageCanvas.OpenCanvasAgain();
        }

        public void ShowRetrieveGoBagCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(true);
            mainBreakerCanvas.SetActive(false);
            goOutCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
       
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

        public void ShowMainBreakerCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(true);
            goOutCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
            SetRoomBarrierColliderActive2(false);

        }

        public void ShowGoOutCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            goOutCanvas.SetActive(true);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
            SetRoomBarrierColliderActive3(false);
            if (waterLevelController != null)
            {
                waterLevelController.SetCanRiseWater(); // Assuming you have a method like SetCanRiseWater in WaterLevelController
            }

        }

        public void ShowDoorJamCanvas(bool show)
        {
            Debug.Log("ShowDoorJamCanvas method called");

            if (show)
            {
                welcomeCanvas.SetActive(false);
                retrieveGoBagCanvas.SetActive(false);
                mainBreakerCanvas.SetActive(false);
                doorJamCanvas.SetActive(true);
                goOutCanvas.SetActive(false);
                roofTop.SetActive(false);
                pryBarCanvas.SetActive(false);
                breakWindowCanvas.SetActive(false);
                searchGoBagCanvas.SetActive(false);
                welldoneCanvas.SetActive(false);
                successCanvas.SetActive(false);
                failedCanvas.SetActive(false);
            DeathCanvas.SetActive(false);
            messageCanvas.OpenCanvasAgain();
            SetRoomBarrierColliderActive4(false);


        }
            else
            {
                doorJamCanvas.SetActive(false);  // Corrected this line
            }
        }


        public void ShowGoRoofTop(bool show)
    {
        if (show)
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(true);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
            DeathCanvas.SetActive(false);
            messageCanvas.OpenCanvasAgain();
     

        }
        else
        {
            roofTop.SetActive(false);  // Corrected this line
        }
    }
        public void ShowPryBarCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(true);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

        public void ShowBreakWindowCanvas()
        {


            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(true);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

    

 
        public void ShowSearchGoBagCanvas(bool show)
    {
        if (show)
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(true);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
            DeathCanvas.SetActive(false);
            messageCanvas.OpenCanvasAgain();
        }
        else
        {
            searchGoBagCanvas.SetActive(false);  // Corrected this line
        }
    }

        public void WelldoneCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(true);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

        public void LocateMobilePhoneCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

        public void SuccessCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(true);
            failedCanvas.SetActive(false);
        DeathCanvas.SetActive(false);
        messageCanvas.OpenCanvasAgain();
        }

        public void FailedCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(true);
          DeathCanvas.SetActive(false);
            messageCanvas.OpenCanvasAgain();
        }

        public void deathCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
            DeathCanvas.SetActive(true);
            messageCanvas.OpenCanvasAgain();
        }

        public void HideAllCanvas()
        {
            welcomeCanvas.SetActive(false);
            retrieveGoBagCanvas.SetActive(false);
            mainBreakerCanvas.SetActive(false);
            doorJamCanvas.SetActive(false);
            roofTop.SetActive(false);
            pryBarCanvas.SetActive(false);
            breakWindowCanvas.SetActive(false);
            searchGoBagCanvas.SetActive(false);
            welldoneCanvas.SetActive(false);
            successCanvas.SetActive(false);
            failedCanvas.SetActive(false);
            DeathCanvas.SetActive(false);
        }










    private void SetRoomBarrierColliderActive1(bool active)
        {
            roomBarrierCollider1.enabled = active;
        }

        private void SetRoomBarrierColliderActive2(bool active)
        {
            roomBarrierCollider2.enabled = active;
        }


        private void SetRoomBarrierColliderActive3(bool active)
        {
            roomBarrierCollider3.enabled = active;
        }

        private void SetRoomBarrierColliderActive4(bool active)
        {
            roomBarrierCollider4.enabled = active;
        }


        // Add any new canvas switch functions here
        public IEnumerator SwitchCanvasAfterDelay()
        {
            // Wait for the specified time before switching to the RetrieveGoBagCanvas
            yield return new WaitForSeconds(switchDelayRetrieveGoBag);

            // Start the fading coroutine
            StartCoroutine(FadeOutSoundAndSwitchCanvas());
        }

        private IEnumerator FadeOutSoundAndSwitchCanvas()
        {
            float startVolume = alarmAudioSource.volume;

            float elapsedTime = 0f;
            while (elapsedTime < fadeOutDuration)
            {
                alarmAudioSource.volume = Mathf.Lerp(startVolume, 0f, elapsedTime / fadeOutDuration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Ensure the volume is set to 0 after fading
            alarmAudioSource.volume = 0f;

            // Stop sound playback
            alarmAudioSource.Stop();

            // Switch to the RetrieveGoBagCanvas after fading completes
            ShowRetrieveGoBagCanvas();
            SetRoomBarrierColliderActive1(false);
        }


        public void FinishCanvas()
        {
            SetRoomBarrierColliderActive1(false);
        }


        private IEnumerator FadeOutSound()
        {
            float startVolume = alarmAudioSource.volume;

            float elapsedTime = 0f;
            while (elapsedTime < fadeOutDuration)
            {
                alarmAudioSource.volume = Mathf.Lerp(startVolume, 0f, elapsedTime / fadeOutDuration);
                elapsedTime += Time.deltaTime;
                yield return null;
            }

            // Ensure the volume is set to 0 after fading
            alarmAudioSource.volume = 0f;

            // Stop sound playback
            alarmAudioSource.Stop();
        }


   

  
    }
