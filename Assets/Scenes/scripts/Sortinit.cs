using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sortinit : MonoBehaviour
{
    [SerializeField] public GridLayoutGroup grid;
    public void Pad() 
    {
        //�Z���T�C�Y�����
        int sizex = 0;
        int sizey = 0;
        //�S�̂̐��@�����
        int wide = 0;
        int height = 0;
        //�[�̃X�y�[�X�����
        int top = 0;
        int bottom = 0;
        int right = 0;
        int left = 0;
        //�z�u�����ƒc�̐�
        int step = 0;
        int line = 0;
        Sort.Instance.Pad(sizex,sizey,wide,height,top,bottom,right,left,step,line,grid);
    }

    public void Space() 
    {
        //�Z���T�C�Y�����
        int sizex = 0;
        int sizey = 0;
        //�S�̂̐��@�����
        int wide = 0;
        int height = 0;
        //�I�u�W�F�N�g�̃X�y�[�X�����
        int widespase = 0;
        int heigtspase = 0;
        //�z�u�����ƒc�̐�
        int step = 0;
        int line = 0;
        Sort.Instance.Space(sizex,sizey,wide,height,widespase,heigtspase,step,line,grid);
    }

    public void Count() 
    {
        //�S�̂̐��@�����
        int wide = 0;
        int height = 0;
        //�I�u�W�F�N�g�̐������
        int count = 0;
        //�I�u�W�F�N�g�A�X�y�[�X�̔䗦�����
        float objxper = 0;
        float objyper = 0;
        float spaceper = 0;
        Sort.Instance.Count(wide,height,count,objxper,objyper,spaceper,grid);
    }
}
