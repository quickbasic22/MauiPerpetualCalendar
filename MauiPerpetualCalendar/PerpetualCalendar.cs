﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPerpetualCalendar
{
    public class PerpetualCalendar
    {
        public List<int> Year1 { get; set; }
        public List<int> Year2 { get; set; }
        public List<int> Year3 { get; set; }
        public List<int> Year4 { get; set; }
        public List<int> Year5 { get; set; }
        public List<int> Year6 { get; set; }
        public List<int> Year7 { get; set; }
        public List<int> Year8 { get; set; }
        public List<int> Year9 { get; set; }
        public List<int> Year10 { get; set; }
        public List<int> Year11 { get; set; }
        public List<int> Year12 { get; set; }
        public List<int> Year13 { get; set; }
        public List<int> Year14 { get; set; }
        public Dictionary<int, int[]> YearList = new();
        public PerpetualCalendar()
        {

            int[] cal1 = new int[] { 1589,
1595,
1606,
1617,
1623,
1634,
1645,
1651,
1662,
1673,
1679,
1690,
1702,
1713,
1719,
1730,
1741,
1747,
1758,
1769,
1775,
1786,
1797,
1809,
1815,
1826,
1837,
1843,
1854,
1865,
1871,
1882,
1893,
1899,
1905,
1911,
1922,
1933,
1939,
1950,
1961,
1967,
1978,
1989,
1995,
2006,
2017,
2023,
2034,
2045,
2051,
2062,
2073,
2079
           };

            int[] cal2 = new int[]
            {
                1590,
1601,
1607,
1618,
1629,
1635,
1646,
1657,
1663,
1674,
1685,
1691,
1703,
1714,
1725,
1731,
1742,
1753,
1759,
1770,
1781,
1787,
1798,
1810,
1821,
1827,
1838,
1849,
1855,
1866,
1877,
1883,
1894,
1900,
1906,
1917,
1923,
1934,
1945,
1951,
1962,
1973,
1979,
1990,
2001,
2007,
2018,
2029,
2035,
2046,
2057,
2063,
2074
            };
            int[] cal3 = new int[]
            {
1585,
1591,
1602,
1613,
1619,
1630,
1641,
1647,
1658,
1669,
1675,
1686,
1697,
1709,
1715,
1726,
1737,
1743,
1754,
1765,
1771,
1782,
1793,
1799,
1805,
1811,
1822,
1833,
1839,
1850,
1861,
1867,
1878,
1889,
1895,
1901,
1907,
1918,
1929,
1935,
1946,
1957,
1963,
1974,
1985,
1991,
2002,
2013,
2019,
2030,
2041,
2047,
2058,
2069,
2075

            };
            int[] cal4 = new int[]
            {
                1586,
1597,
1603,
1625,
1614,
1631,
1642,
1653,
1659,
1670,
1681,
1687,
1698,
1710,
1721,
1727,
1738,
1749,
1755,
1766,
1777,
1783,
1794,
1800,
1806,
1817,
1823,
1834,
1845,
1851,
1862,
1873,
1879,
1890,
1902,
1913,
1919,
1930,
1941,
1947,
1958,
1969,
1975,
1986,
1997,
2003,
2014,
2025,
2031,
2042,
2053,
2059,
2070,

            };
            int[] cal5 = new int[]
            {
                1587,
1598,
1609,
1615,
1626,
1637,
1643,
1654,
1665,
1671,
1682,
1693,
1699,
1705,
1711,
1722,
1733,
1739,
1750,
1761,
1767,
1778,
1789,
1795,
1801,
1807,
1818,
1829,
1835,
1846,
1857,
1863,
1874,
1885,
1891,
1903,
1914,
1925,
1931,
1942,
1953,
1959,
1970,
1981,
1987,
1998,
2009,
2015,
2026,
2037,
2043,
2054,
2065,
2071

            };
            int[] cal6 = new int[]
            {
                1593,
1599,
1610,
1621,
1627,
1638,
1649,
1655,
1666,
1677,
1683,
1694,
1700,
1706,
1717,
1723,
1734,
1745,
1751,
1762,
1773,
1779,
1790,
1802,
1813,
1819,
1830,
1841,
1847,
1858,
1869,
1875,
1886,
1897,
1909,
1915,
1926,
1937,
1943,
1954,
1965,
1971,
1982,
1993,
1999,
2010,
2021,
2027,
2038,
2049,
2055,
2066,
2077

            };
            int[] cal7 = new int[]
            {
                1583,
1594,
1605,
1611,
1622,
1633,
1639,
1650,
1661,
1667,
1678,
1689,
1695,
1701,
1707,
1718,
1729,
1735,
1746,
1757,
1763,
1774,
1785,
1791,
1803,
1814,
1825,
1831,
1842,
1853,
1859,
1870,
1881,
1887,
1898,
1910,
1921,
1927,
1938,
1949,
1955,
1966,
1977,
1983,
1994,
2005,
2011,
2022,
2033,
2039,
2050,
2061,
2067,
2078

            };
            int[] cal8 = new int[]
            {
                1584,
1612,
1640,
1668,
1696,
1708,
1736,
1764,
1792,
1804,
1832,
1860,
1888,
1928,
1956,
1984,
2012,
2040,
2068

            };
            int[] cal9 = new int[]
            {
                1596,
1624,
1652,
1680,
1720,
1748,
1776,
1816,
1844,
1872,
1912,
1940,
1968,
1996,
2024,
2052,
2080

            };
            int[] cal10 = new int[]
            {
1608,
1636,
1664,
1692,
1704,
1732,
1760,
1788,
1828,
1856,
1884,
1924,
1952,
1980,
2008,
2036,
2064

            };
            int[] cal11 = new int[]
            {
                1592,
1620,
1648,
1676,
1716,
1744,
1772,
1812,
1840,
1868,
1896,
1908,
1936,
1964,
1992,
2020,
2048,
2076

            };
            int[] cal12 = new int[] {
                1604,
1632,
1660,
1688,
1728,
1756,
1784,
1824,
1852,
1880,
1920,
1948,
1976,
2004,
2032,
2060

            };
            int[] cal13 = new int[]
            {
                1588,
1616,
1644,
1672,
1712,
1740,
1768,
1796,
1808,
1836,
1864,
1892,
1904,
1932,
1960,
1988,
2016,
2044,
2072

            };
            int[] cal14 = new int[]
            {
                1600,
1628,
1656,
1684,
1724,
1752,
1780,
1820,
1848,
1876,
1916,
1944,
1972,
2000,
2028,
2056

            };

            YearList.Add(1, cal1);
            YearList.Add(2, cal2);
            YearList.Add(3, cal3);
            YearList.Add(4, cal4);
            YearList.Add(5, cal5);
            YearList.Add(6, cal6);
            YearList.Add(7, cal7);
            YearList.Add(8, cal8);
            YearList.Add(9, cal9);
            YearList.Add(10, cal10);
            YearList.Add(11, cal11);
            YearList.Add(12, cal12);
            YearList.Add(13, cal13);
            YearList.Add(14, cal14);


        }
    }
}