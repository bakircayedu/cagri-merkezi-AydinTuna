using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veri_Yapıları_Çağrı_Merkezi_Ödevi
{
    public class BireyselMusteriLinkedList
    {
        public NodeB head;
        public int sayac = 0;

        public BireyselMusteriLinkedList()
        {
            head = null;
        }

        // Başa Ekleme
        public void basaEkle(int data)
        {
            
            NodeB eleman = new NodeB(data);

            if (head == null)
            {
                head = eleman;
                sayac++;
            }
            else
            {
                eleman.next = head;
                head = eleman;
                sayac++;
            }
        }

        // Baştan Sil
        public void bastanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Baştan eleman silindi");
                sayac--;
            }
        }

        // Sondan Sil
        public void sondanSil()
        {
            if (head == null)
            {
                Console.WriteLine("Liste boş");
            }
            else
            {
                NodeB temp = head;
                NodeB temp2 = null;
                while (temp.next != null)
                {
                    temp2 = temp;
                    temp = temp.next;
                }
                temp2.next = null;
                Console.WriteLine("Sondaki eleman silindi");
                sayac--;
            }
        }

        // Aradan Sil
        public void aradanSil(int index)
        {
            bool sonuc = false;

            if (head == null)
            {
                sonuc = true;
                Console.WriteLine("Liste boş");
            }

            else if (head.next == null && index == 0)
            {
                head = null;
                Console.WriteLine("Listede kalan son eleman da silindi.");
                sonuc = true;
                sayac--;
            }
            else if (head.next != null && index == 0)
            {
                bastanSil();
                Console.WriteLine("Eleman silindi");
                sonuc = true;
                sayac--;
            }

            else
            {
                int i = 0;
                NodeB temp = head;
                NodeB temp2 = temp;
                while (temp.next != null)
                {
                    if (i == index)
                    {
                        sonuc = true;
                        temp2.next = temp.next;
                        Console.WriteLine("Aradan eleman silindi");
                        i++;
                        sayac--;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index)
                {
                    sonuc = true;
                    temp2.next = null;
                    Console.WriteLine("Aradan eleman silindi");
                    sayac--;
                    i++;
                }
            }
            if (sonuc == false)
            {
                Console.WriteLine("Hatalı index seçimi yaptınız");
            }
        }

        // Yazdırma
        string mesaj;
        public string yazdir()
        {
            mesaj = "";
            
            NodeB temp = head;
            mesaj += "Son -> ";
            while (temp != null)
            {
                mesaj += temp.data + " -> ";
                temp = temp.next;
            }
            return mesaj;
        }

        // Sırada Arama
        public string SiradaArama(int arananEleman)
        {
            int i = sayac + 1;
            NodeB temp = head;
            while (temp != null)
            {
                i--;
                if (temp.data == arananEleman) break;
                temp = temp.next;
            }
            return i + ". sıradasınız.";
        }


        // Arama Yapma
        public int Arama(NodeB head, int x)
        {
            sayac = 0;
            NodeB current = head;
            while (current != null)
            {
                if (current.data == x)
                    return sayac;
                current = current.next;
                sayac++;
            }
            return 0;
        }
    }

    public class NodeB
    {
        public int data;
        public NodeB next;

        public NodeB(int data)
        {
            this.data = data;
            next = null;
        }
    }
}
