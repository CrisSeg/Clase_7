﻿using System;

namespace Clase_7
{
	public interface Comparable
	{
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		string toString();
	}
}
