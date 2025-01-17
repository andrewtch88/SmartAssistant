/*
This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software Foundation,
Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301, USA.

The Original Code is Copyright (C) 2020 Voxell Technologies.
All rights reserved.
*/

using UnityEngine;

namespace Audio
{
  [System.Serializable]
  public class AudioProfile
  {
    public int channel;
    public FFTWindow window;
    public int sampleSize;
    public int bufferSize;
    public float power;
    public float scale;
    public float sensitivity;
    public int smoothingIterations;
    [Range(5000, 20000)]
    public int freqRange;
    [Range(10, 100)]
    public int bandSize;
  }
}
