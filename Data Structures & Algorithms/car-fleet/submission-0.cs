public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var cars= new int[n][];

        for(int i = 0;i<position.Length;i++){
            cars[i] = new int[] { position[i], speed[i] };
        }

        Array.Sort(cars,(a,b) => b[0]-a[0]);

        int fleet = 0; 
        double leadTime = -1;

        for(int i = 0;i<n;i++){

             int carPosition = cars[i][0];
             int carSpeed    = cars[i][1];

            int distance = target - carPosition;
            double time = (double)distance/carSpeed;

            if(time > leadTime){
                fleet = fleet + 1;
                leadTime = time;
            }
            else{
                //join the fleet
            }
        }
        return fleet;
        
    }
}
