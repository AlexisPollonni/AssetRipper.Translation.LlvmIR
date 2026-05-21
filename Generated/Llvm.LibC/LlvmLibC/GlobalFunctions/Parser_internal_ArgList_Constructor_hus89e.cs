using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_Constructor_hus89e
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEEC2EPKcRS3_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::Parser(char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	[CleanName("Parser_internal_ArgList_Constructor")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("new_str")][NativeType("char const*")] void* New_str, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Llvm_libc_20_1_2_internal_ArgList* Args)
	{
		This->Str = New_str;
		This->Cur_pos = 0L;
		ArgList_Constructor_z4jw9r.Invoke(&This->Args_cur, Args);
		ArgList_Constructor_z4jw9r.Invoke(&This->Args_start, Args);
		This->Args_index = 1L;
		InlineArray128_Llvm_libc_20_1_2_printf_core_TypeDesc* desc_arr = &This->Desc_arr;
		unchecked
		{
			*(short*)desc_arr = Printf_core_type_desc_from_type_void_kvifr8.Invoke();
			nint num = (nint)((byte*)desc_arr + sizeof(Llvm_libc_20_1_2_printf_core_TypeDesc));
			Llvm_libc_20_1_2_printf_core_TypeDesc* ptr = (Llvm_libc_20_1_2_printf_core_TypeDesc*)desc_arr + 128L;
			while (true)
			{
				void* ptr2 = (void*)num;
				((Llvm_libc_20_1_2_printf_core_TypeDesc*)ptr2)->Size = 0;
				((Llvm_libc_20_1_2_printf_core_TypeDesc*)ptr2)->Primary_type = PrimaryType.Unknown;
				Llvm_libc_20_1_2_printf_core_TypeDesc* ptr3 = (Llvm_libc_20_1_2_printf_core_TypeDesc*)ptr2 + 1;
				if (ptr3 != ptr)
				{
					num = (nint)ptr3;
					continue;
				}
				break;
			}
		}
	}
}
