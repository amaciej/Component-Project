import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.Rectangle;
import java.awt.RenderingHints;

import javax.swing.JSlider;
import javax.swing.plaf.basic.BasicSliderUI;

enum Kolory{
    Czerwony,
    Zielony,
    Niebieski,
    Domyslny
}

enum Orientacja{
    Pozioma,
    Pionowa
}

enum Ksztalty{
    Linia,
    Trojkat,
    Serce
}

public class Suwak extends JSlider{
    
    public Suwak(){
        this.setUI(new BasicSliderUI(this){
            @Override
            public void paintThumb(Graphics g){
            Graphics2D g2d = (Graphics2D) g;
            g2d.setRenderingHint(
            RenderingHints.KEY_ANTIALIASING,
            RenderingHints.VALUE_ANTIALIAS_ON);
            Rectangle t = thumbRect;
            g2d.setColor(Color.black);
            int tw2 = t.width / 2;
            
            if (Ksztalt == Ksztalt.Linia){
                if (Polozenie == Orientacja.Pionowa)
                    g2d.drawLine(t.x, t.y, t.x + t.width, t.y);
                if (Polozenie == Orientacja.Pozioma)
                    g2d.drawLine(t.x, t.y, t.x, t.y + t.height);
            }
            else if (Ksztalt == Ksztalt.Trojkat){
                g2d.drawLine(t.x, t.y, t.x + t.width - 1, t.y);
                g2d.drawLine(t.x, t.y, t.x + tw2, t.y + t.height);
                g2d.drawLine(t.x + t.width - 1, t.y, t.x + tw2, t.y + t.height);
            }
            else{
                drawHeart(g2d, t.x, t.y, t.width, t.height);
            }
            
            invalidate();
            }
        });
    }
    
    private Kolory Kolor;
    
    public Kolory getKolor(){
        return Kolor;
    }
    
    public void setKolor(Kolory _kolory){
        Kolor = _kolory;
        
        setBackground(new Color(240, 240, 240));
        
        if (Kolor == Kolory.Czerwony)
            setBackground(Color.RED);
        if (Kolor == Kolory.Niebieski)
            setBackground(Color.BLUE);
        if (Kolor == Kolory.Zielony)
            setBackground(Color.GREEN);
        
        invalidate();
    }
    
    private Orientacja Polozenie;
    
    public Orientacja getPolozenie(){
        return Polozenie;
    }
    
    public void setPolozenie(Orientacja _orientacja){
        Polozenie = _orientacja;
        
        if (Polozenie == Orientacja.Pionowa){
            setOrientation(VERTICAL);
            setPreferredSize(new Dimension(Wysokosc, Szerokosc));
        }
        if (Polozenie == Orientacja.Pozioma){
            setOrientation(HORIZONTAL);
            setPreferredSize(new Dimension(Szerokosc, Wysokosc));
        }
        
        invalidate();
    }
    
    private Ksztalty Ksztalt;
    
    public Ksztalty getKsztalt(){
        return Ksztalt;
    }
    
    public void setKsztalt(Ksztalty _ksztalty){
        Ksztalt = _ksztalty;
    }
    
    private int Szerokosc = 100;
    
    public int getSzerokosc(){
        return Szerokosc;
    }
    
    public void setSzerokosc(int _szerokosc){
        Szerokosc = _szerokosc;
        
        setPolozenie(Polozenie);
        invalidate();
    }
    
    private int Wysokosc = 100;
    
    public int getWysokosc(){
        return Wysokosc;
    }
    
    public void setWysokosc(int _wysokosc){
        Wysokosc = _wysokosc;
        
        setPolozenie(Polozenie);
        invalidate();
    }
    
    public void drawHeart(Graphics g, int x, int y, int width, int height) {
    int[] triangleX = {
            x - 2*width/18,
            x + width + 2*width/18,
            (x - 2*width/18 + x + width + 2*width/18)/2};
    int[] triangleY = { 
            y + height - 2*height/3, 
            y + height - 2*height/3, 
            y + height };
    g.fillOval(
            x - width/12,
            y, 
            width/2 + width/6, 
            height/2); 
    g.fillOval(
            x + width/2 - width/12,
            y,
            width/2 + width/6,
            height/2);
    g.fillPolygon(triangleX, triangleY, triangleX.length);
}
}
