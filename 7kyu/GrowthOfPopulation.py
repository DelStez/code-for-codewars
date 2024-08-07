def nb_year(p0, percent, aug, p, need_years =0):
    return need_years if p0>=p else nb_year(
        int(p0 + p0 * (percent/100)+aug),percent, aug, p, need_years+1)