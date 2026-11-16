internal class Leds
{
    private byte status;

    public Leds()
    {
        this.status = 0;
    }

    public Leds(byte status)
    {
        this.status = status;
    }

    public void acender(int led)
    {

        this.status = (byte)(this.status | (1 << led));
    }

    public void apagar(int led)
    {
        this.status = (byte)(this.status & ~(1 << led));
    }

    public byte getStatus()
    {
        return this.status;
    }

    public bool getStatus(int led)
    {
        return (this.status & (1 << led)) != 0;
    }
}