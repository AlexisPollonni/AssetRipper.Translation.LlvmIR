using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_resize_overflow_hook
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, Llvm_libc_20_1_2_printf_core_WriteBuffer*, int>)(&Invoke));

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core20resize_overflow_hookENS_3cpp11string_viewEPv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::resize_overflow_hook(__llvm_libc_20_1_2_::cpp::string_view, void*)")]
	public unsafe static int Invoke([MangledName("new_str.coerce0")] void* New_str, [MangledName("new_str.coerce1")][NativeType("__llvm_libc_20_1_2_::cpp::string_view")] long Target, [MangledName("target")][NativeType("void*")] Llvm_libc_20_1_2_printf_core_WriteBuffer* Wb)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		void* ptr = null;
		long num = 0L;
		sbyte b = 0;
		void* ptr2 = null;
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = New_str;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Target;
			Llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = Wb;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view) + ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff_cur;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff == ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Init_buff) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = (((b & 1) != 1) ? Realloc.Invoke(((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff, num + 1L) : Malloc.Invoke(num + 1L));
			int result;
			if (ptr2 == null)
			{
				if (((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff != ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Init_buff)
				{
					Free.Invoke(((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff);
				}
				result = -6;
			}
			else
			{
				if ((b & 1) == 1)
				{
					Llvm_libc_20_1_2_inline_memcpy.Invoke(ptr2, ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff, ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff_cur);
				}
				((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff = ptr2;
				Llvm_libc_20_1_2_inline_memcpy.Invoke((byte*)((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff + ((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff_cur, String_view_data.Invoke(&llvm_libc_20_1_2_cpp_string_view), String_view_size.Invoke(&llvm_libc_20_1_2_cpp_string_view));
				((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff_cur = num;
				((Llvm_libc_20_1_2_printf_core_WriteBuffer*)ptr)->Buff_len = num;
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
