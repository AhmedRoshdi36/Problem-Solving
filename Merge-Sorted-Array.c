void merge(int* nums1, int nums1Size, int m, int* nums2, int nums2Size, int n) {
    int list1 = 0;
    int list2 = 0;
    int i = 0;
    int temp[400];
    while (list1 < m && list2 < n) {
        if (nums1[list1] < nums2[list2]) {
            temp[i] = nums1[list1];
            list1++;
            i++;
        } else {
            temp[i] = nums2[list2];
            list2++;
            i++;
        }
    }
        while (list1 < m) {
            temp[i] = nums1[list1];
            list1++;
            i++;
        }

    
        while (list2 < n) {
            temp[i] = nums2[list2];
            list2++;
            i++;
        
    }
    for (i = 0; i < m + n; i++) {
        nums1[i] = temp[i];
    }
}