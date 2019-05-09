using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SequenceInterface
{

    public string tagName { get; set; }
    public string date { get; set; }
    public int index { get; set; }
    public string title { get; set; }
    public string note { get; set; }
    public string[] actors;
    public string[] events;

}


public class SequenceManager : MonoBehaviour
{
    public static SequenceManager instance = null;

    int inc = 0;
    List<SequenceInterface> sequences = new List<SequenceInterface>{
            new SequenceInterface {
                tagName="firstSeq",
                date="1478",
                index=0,
                events= new string[]{"", ""},
                title="L'attaque de Maximilien",
                note=@"Thérouane se situe sur une frontière.
                    Maximilien retente de prendre Thérouanne et y parvint la nuit du 9 Juin 1486
                    Charles VIII riposte mais s'enlise.
                    Le maréchal d'Esquerdes aux avant-postes tente d'affamer la ville et les troupes adverses en rasant les récoltes et en bloquant les aprovisionements mais ce fut un échec grace aux différentes manoeuvres de Maximilien (Traité de ravitallement avec Saint-Omer, convois secrets)
                    Les français réussissent finalement à reprendre Thérouanne par la ruse au 26 Juillet 1487, sans combat. 
                    Si d'Esquerdes a pris l'accendant sur un Maximilien qui peut difficilement résister, la paix est négociée sous la forme d'une réparttions des territoires et des communes.",
                actors = new string[]{"Portrait de Maximilien", "Marie", " Louis XI", "Esquerdes"},
            },
            new SequenceInterface {
                tagName="secondSeq",
                date="1578",
                index=0,
                title="L'attaque de Maximilien",
                note=@"Thérouane se situe sur une frontière.
                    Maximilien retente de prendre Thérouanne et y parvint la nuit du 9 Juin 1486
                    Charles VIII riposte mais s'enlise.
                    Le maréchal d'Esquerdes aux avant-postes tente d'affamer la ville et les troupes adverses en rasant les récoltes et en bloquant les aprovisionements mais ce fut un échec grace aux différentes manoeuvres de Maximilien (Traité de ravitallement avec Saint-Omer, convois secrets)
                    Les français réussissent finalement à reprendre Thérouanne par la ruse au 26 Juillet 1487, sans combat. 
                    Si d'Esquerdes a pris l'accendant sur un Maximilien qui peut difficilement résister, la paix est négociée sous la forme d'une réparttions des territoires et des communes.",
                actors = new string[]{"Portrait de Maximilien", "Marie", " Louis XI", "Esquerdes"},
            },
            new SequenceInterface {
                tagName="thirdSeq",
                date="1678",
                index=0,
                title="L'attaque de Maximilien",
                note=@"Thérouane se situe sur une frontière.
                    Maximilien retente de prendre Thérouanne et y parvint la nuit du 9 Juin 1486
                    Charles VIII riposte mais s'enlise.
                    Le maréchal d'Esquerdes aux avant-postes tente d'affamer la ville et les troupes adverses en rasant les récoltes et en bloquant les aprovisionements mais ce fut un échec grace aux différentes manoeuvres de Maximilien (Traité de ravitallement avec Saint-Omer, convois secrets)
                    Les français réussissent finalement à reprendre Thérouanne par la ruse au 26 Juillet 1487, sans combat. 
                    Si d'Esquerdes a pris l'accendant sur un Maximilien qui peut difficilement résister, la paix est négociée sous la forme d'une réparttions des territoires et des communes.",
                actors = new string[]{"Portrait de Maximilien", "Marie", " Louis XI", "Esquerdes"},
            },
            new SequenceInterface {
                tagName="fourthSeq",
                date="1778",
                index=0,
                title="L'attaque de Maximilien",
                note=@"Thérouane se situe sur une frontière.
                    Maximilien retente de prendre Thérouanne et y parvint la nuit du 9 Juin 1486
                    Charles VIII riposte mais s'enlise.
                    Le maréchal d'Esquerdes aux avant-postes tente d'affamer la ville et les troupes adverses en rasant les récoltes et en bloquant les aprovisionements mais ce fut un échec grace aux différentes manoeuvres de Maximilien (Traité de ravitallement avec Saint-Omer, convois secrets)
                    Les français réussissent finalement à reprendre Thérouanne par la ruse au 26 Juillet 1487, sans combat. 
                    Si d'Esquerdes a pris l'accendant sur un Maximilien qui peut difficilement résister, la paix est négociée sous la forme d'une réparttions des territoires et des communes.",
                actors = new string[]{"Portrait de Maximilien", "Marie", " Louis XI", "Esquerdes"},
            }
    };

    public SequenceInterface sequence;
    public Text title;
    public Text date;
    public Text note;







    void refreshView()
    {
        title.text = sequence.title;
        date.text = sequence.date;
        note.text = sequence.note;
    }









    public void setSequence(int index)
    {
        if (index > sequences.Count - 1 || index < 0)
        {
            Debug.LogError("Index out of range in sequences");
        }
        else
        {
            sequence = sequences[index];
            refreshView();
        }
    }









    public void setSequenceUpOrDown(int index)
    {

        if (index == 1)
        {
            inc++;
        }
        else if (index == -1)
        {
            inc--;
        }
        if (inc > sequences.Count - 1 || inc < 0)
        {
            inc = 0;
        }
        setSequence(inc);
    }







    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);

        setSequence(inc);
        // sequences.ForEach(delegate (SequenceInterface el)
        // {

        // });
    }
}
