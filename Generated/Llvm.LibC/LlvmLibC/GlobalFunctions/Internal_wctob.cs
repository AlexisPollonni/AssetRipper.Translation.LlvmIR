using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_wctob
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal5wctobEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::wctob(unsigned int)")]
	public unsafe static long Invoke([MangledName("c")][NativeType("unsigned int")] int C)
	{
		Cpp_optional_g66fk4 cpp_optional_g66fk = default(Cpp_optional_g66fk4);
		int num = 0;
		if ((C & -128) != 0)
		{
			Optional_int_Constructor_ucy85v.Invoke(&cpp_optional_g66fk);
		}
		else
		{
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = C;
			Optional_int_Constructor_952vg9.Invoke(&cpp_optional_g66fk, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
		return *unchecked((long*)(&cpp_optional_g66fk.Storage));
	}
}
