using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class iscanonicalf
{
	public unsafe static int Invoke(float x)
	{
		float num = 0f;
		float num2 = x;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = float.NaN;
		bool result = fputil_canonicalize_float_0.Invoke(&num, &num2) == 0;
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result ? 1 : 0;
	}
}
