namespace TopCoder
{
    public class KiwiJuiceEasy
    {
        public int[] ThePouring(int[] capacities, int[] bottles, int[] fromId, int[] toId)
        {
            var result = bottles;

            for (int index = 0; index < fromId.Length; ++index)
            {
                var fromBottleIndex = fromId[index];
                var toBottleIndex = toId[index];

                var toCapacity = capacities[toBottleIndex];

                var fromBottle = result[fromBottleIndex];
                var toBottle = result[toBottleIndex];

                var sum = fromBottle + toBottle;
                var remain = (sum > toCapacity) ? sum - toCapacity : 0;
                result[fromBottleIndex] = remain;
                result[toBottleIndex] = (sum > toCapacity) ? toCapacity : sum;
            }

            return result;
        }
    }
}
