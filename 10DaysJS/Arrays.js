function getSecondLargest(nums) {
    var largestVal = nums[0];
    var secondLargetVal = nums[0];
    for (var i = 0; i < nums.length; i++) {
        if (nums[i] > largestVal) {
            secondLargetVal = largestVal;
            largestVal = nums[i];
        }
        if (nums[i] > secondLargetVal && nums[i] !== largestVal) {
            secondLargetVal = nums[i];
        }
    }

    return secondLargetVal;
}

console.log(getSecondLargest([2, 3, 6, 6, 5]))
console.log(getSecondLargest([2, 3, 6, 6, 5, 4, 7, 9]))