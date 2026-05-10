using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class div
{
	public unsafe static long Invoke(int x, int y)
	{
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		unchecked
		{
			*(int*)(&internal_ExpandedFloat_i7t5up2) = -1431655766;
			((int*)(&internal_ExpandedFloat_i7t5up2))[1] = -1431655766;
			cpp_enable_if_cpp_is_integral_v_int_void_type_integer_rem_quo_int_int_int_int_int.Invoke(x, y, &internal_ExpandedFloat_i7t5up2.mantissa, &internal_ExpandedFloat_i7t5up2.exponent);
			return *(long*)(&internal_ExpandedFloat_i7t5up2);
		}
	}
}
