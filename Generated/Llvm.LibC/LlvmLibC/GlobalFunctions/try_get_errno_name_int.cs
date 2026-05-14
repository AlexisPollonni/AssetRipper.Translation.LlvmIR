using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_18try_get_errno_nameEi")]
[DemangledName("__llvm_libc_20_1_2_::try_get_errno_name(int)")]
internal static partial class try_get_errno_name_int
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_bnt67x* agg_result, int err_num)
	{
		MessageMapper_134ul_3113ul_get_str_int_const.Invoke(agg_result, unchecked((MessageMapper_8a2hs7*)internal_ERRNO_NAME_MAPPER.Pointer), err_num);
	}
}
