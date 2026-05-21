using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Btowc
{
	[MangledName("btowc")]
	[DemangledName("btowc")]
	public unsafe static int Invoke([MangledName("c")] int C)
	{
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk);
			*(int*)ptr = -1431655766;
			ptr[4] = -86;
			sbyte* ptr2 = ptr + 5;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			long storage = Internal_btowc.Invoke(C);
			*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk.Storage) = storage;
			int result = ((!Optional_unsigned_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk)) ? (-1) : (*(int*)Optional_unsigned_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk)));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk);
			return result;
		}
	}
}
