using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Wctob
{
	[MangledName("wctob")]
	[DemangledName("wctob")]
	public unsafe static int Invoke([MangledName("c")] int C)
	{
		Cpp_optional_g66fk4 cpp_optional_g66fk = default(Cpp_optional_g66fk4);
		Llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_optional_g66fk);
			*(int*)ptr = -1431655766;
			ptr[4] = -86;
			sbyte* ptr2 = ptr + 5;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			long storage = Internal_wctob.Invoke(C);
			*(long*)(&cpp_optional_g66fk.Storage) = storage;
			int result = ((!Optional_int_has_value.Invoke(&cpp_optional_g66fk)) ? (-1) : (*(int*)Optional_int_value.Invoke(&cpp_optional_g66fk)));
			Llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk);
			return result;
		}
	}
}
