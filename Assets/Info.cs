using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Info : MonoBehaviour
{
    public TMP_Text displayText; // Use TMP_Text for TextMeshPro

    void Update()
    {
        // Check if left mouse button is clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Cast a ray from the mouse position into the scene
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Check if the ray hits any object
            if (Physics.Raycast(ray, out hit))
            {
                switch (hit.collider.gameObject.name){
                    case "Coccyx":
                        displayText.text = "The coccyx, or tailbone, is a small triangular bone located at the base of the spine. It provides attachment for pelvic floor muscles and supports the body when sitting, but can be susceptible to injury and cause pain (coccydynia) when affected.";
                        break;
                    case "Sacrum":
                        displayText.text = "The sacrum is a triangular bone located at the base of the spine, between the two hip bones (ilia) of the pelvis. It consists of five fused vertebrae and forms the posterior part of the pelvic girdle. The sacrum connects the spine to the pelvis and helps to transmit the weight of the body to the lower limbs.";
                        break;
                    case "L5":
                        displayText.text = "L5, or the fifth lumbar vertebra, is the last of the five lumbar vertebrae in the lower back region of the spine. It is the largest and strongest lumbar vertebra, supporting the weight of the upper body and transmitting it to the pelvis and lower limbs. Injuries or issues with L5 can cause lower back pain and affect mobility.";
                        break;
                    case "L4":
                        displayText.text = "L4, or the fourth lumbar vertebra, is located in the lower back region of the spine, just above the L5 vertebra. It contributes to supporting the upper body's weight and plays a role in movement and flexibility of the lower back. Issues with L4 can result in lower back pain, nerve compression, or mobility problems affecting the lower body.";
                        break;
                    case "L3":
                        displayText.text = "L3 is the third lumbar vertebra in the lower back. It supports the upper body and aids in lower back movement. Problems with L3 can cause lower back pain and mobility issues.";
                        break;
                    case "L2":
                        displayText.text = "L2 is the second lumbar vertebra in the lower back. It provides support for the upper body and assists in bending and twisting of the lower back. Issues with L2 can lead to lower back pain and mobility limitations.";
                        break;
                   case "L1":
                       displayText.text = "L1 is the first lumbar vertebra in the lower back region of the spine. It supports the weight of the upper body and assists in bending and twisting motions of the lower back. Problems with L1 can result in lower back pain and mobility challenges.";
                       break;
                   case "T12":
                       displayText.text = "T12 is the last thoracic vertebra located in the upper and middle back, above the lumbar spine. It supports the upper body and contributes to back flexibility. Issues with T12 can cause mid-back pain and affect spinal stability.";
                       break;
                   case "T11":
                       displayText.text = "T11 is the eleventh thoracic vertebra located in the upper back region, below T10 and above T12. It supports the rib cage and contributes to overall back stability. Problems with T11 can lead to upper back pain and affect posture and mobility.";
                       break;
                    case "T10":
                        displayText.text = "T10 is the tenth thoracic vertebra located in the upper back, below T9 and above T11. It plays a role in supporting the rib cage and maintaining back stability. Issues with T10 can cause upper back pain and impact posture and movement.";
                        break;
                    case "T9":
                        displayText.text = "T9 is the ninth thoracic vertebra located in the upper back, below T8 and above T10. It provides support to the rib cage and helps maintain back stability. Problems with T9 can result in upper back pain and affect posture and mobility.";
                        break;
                    case "T8":
                        displayText.text = "T8 is the eighth thoracic vertebra located in the upper back, below T7 and above T9. It supports the rib cage and contributes to overall back stability. Issues with T8 can cause upper back pain and impact posture and movement.";
                        break;
                    case "T7":
                        displayText.text = "T7 is the seventh thoracic vertebra located in the upper back, below T6 and above T8. It plays a role in supporting the rib cage and maintaining back stability. Problems with T7 can lead to upper back pain and affect posture and mobility.";
                        break;
                    case "T6":
                        displayText.text = "T6 is the sixth thoracic vertebra located in the upper back, below T5 and above T7. It supports the rib cage and helps maintain back stability. Issues with T6 can cause upper back pain and affect posture and movement.";
                        break;
                    case "T5":
                        displayText.text = "T5 is the fifth thoracic vertebra located in the upper back, below T4 and above T6. It supports the rib cage and contributes to back stability. Problems with T5 can lead to upper back pain and affect posture and mobility.";
                        break; 
                    case "T4":
                        displayText.text = "T4 is the fourth thoracic vertebra located in the upper back, below T3 and above T5. It supports the rib cage and helps maintain back stability. Issues with T4 can cause upper back pain and affect posture and mobility.";
                        break;
                    case "T3":
                        displayText.text = "T3 is the third thoracic vertebra located in the upper back, below T2 and above T4. It supports the rib cage and contributes to back stability. Problems with T3 can lead to upper back pain and affect posture and mobility.";
                        break; 
                    case "T2":
                        displayText.text = "T2 is the second thoracic vertebra located in the upper back, below T1 and above T3. It supports the rib cage and contributes to back stability. Issues with T2 can cause upper back pain and affect posture and mobility.";
                        break;
                    case "T1":
                        displayText.text = "T1 is the first thoracic vertebra located in the upper back, below the cervical vertebra C7 and above T2. It supports the rib cage and contributes to back stability. Issues with T1 can cause upper back pain and affect posture and mobility.";
                        break;
                    case "C7":
                        displayText.text = "C7 is the lowest cervical vertebra in the neck, supporting head and neck movement. Problems with C7 can cause neck pain and affect upper body mobility.";
                        break;
                    case "C6":
                        displayText.text = "C6 is the sixth cervical vertebra located in the neck, below C5 and above C7. It supports the neck and contributes to head movement and flexibility. Issues with C6 can lead to neck pain and affect mobility in the upper body.";
                        break;
                    case "C5":
                        displayText.text = "C5 is the fifth cervical vertebra located in the neck, below C4 and above C6. It supports the neck and contributes to head movement and flexibility. Problems with C5 can cause neck pain and affect mobility in the upper body.";
                        break;
                    case "C4":
                        displayText.text = "C4 is the fourth cervical vertebra located in the neck, below C3 and above C5. It supports the neck and contributes to head movement and flexibility. Issues with C4 can cause neck pain and impact mobility in the upper body.";
                        break;
                    case "C3":
                        displayText.text = "C3 is the third cervical vertebra located in the neck, below C2 and above C4. It supports the neck and contributes to head movement and flexibility. Problems with C3 can cause neck pain and affect mobility in the upper body.";
                        break;
                    case "C2":
                        displayText.text = "C2, also known as the second cervical vertebra or the axis, is located in the neck just below C1 (atlas) and above C3. It plays a crucial role in supporting the head and allowing for rotation of the neck. Issues with C2 can lead to neck pain, stiffness, or restricted movement in the upper neck region.";
                        break;
                    case "C1":
                        displayText.text = "C1, also known as the first cervical vertebra or the atlas, is located at the top of the spine, just below the skull and above C2. It supports the skull and allows for the nodding motion of the head. Issues with C1 can lead to neck pain, headaches, or restricted movement in the upper neck area.";
                        break;
                }
            }
            else
            {
                displayText.text = "";
            }
        }
    }
}
